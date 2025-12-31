using RepublicTK.Scripts;

namespace WRMapOverlay;

public record GameSave(string Directory)
{
    private static readonly string[] RequiredFiles = ["material.mtl", "script.ini"];

    public string Name
    {
        get => Path.GetFileName(Directory);
    }

    public void SetOverlay(string overlayPath)
    {
        if (overlayPath.Any(char.IsWhiteSpace))
        {
            throw new ArgumentException("The path cannot contain whitespaces.", nameof(overlayPath));
        }

        string scriptPath = Path.Combine(Directory, "script.ini");
        string materialPath = Path.Combine(Directory, "material.mtl");

        var script = new Script(File.ReadAllText(scriptPath));
        var material = new Script(File.ReadAllText(materialPath));

        if (script.FindToken("$TILESIZE1"))
        {
            script.ReadValue<float>();
            script.RemoveSelection();
            script.Prepend("$TILESIZE1", "1.0000");
        }

        if (material.FindToken("$TEXTURE"))
        {
            material.ReadValue<string>(1);
            material.RemoveSelection();
            material.Prepend("$TEXTURE", 5, overlayPath);
        }

        try
        {
            File.WriteAllText(scriptPath, script.ScriptContent);
            File.WriteAllText(materialPath, material.ScriptContent);
        }
        catch { }
    }

    public string? GetOverlay()
    {
        string scriptPath = Path.Combine(Directory, "script.ini");
        string materialPath = Path.Combine(Directory, "material.mtl");

        var script = new Script(File.ReadAllText(scriptPath));
        var material = new Script(File.ReadAllText(materialPath));

        if (material.FindToken("$TEXTURE"))
        {
            var biome = GetBiome(script);
            var currentOverlayPath = material.ReadValue<string>(offset: 1);
            var defaultOverlayPath = GetDefaultTextureForBiome(biome);

            if (currentOverlayPath != defaultOverlayPath)
            {
                return currentOverlayPath;
            }
        }

        return null;
    }

    public void RemoveOverlay()
    {
        string scriptPath = Path.Combine(Directory, "script.ini");
        string materialPath = Path.Combine(Directory, "material.mtl");

        var script = new Script(File.ReadAllText(scriptPath));
        var material = new Script(File.ReadAllText(materialPath));

        if (script.FindToken("$TILESIZE1"))
        {
            script.ReadValue<float>();
            script.RemoveSelection();
            script.Prepend("$TILESIZE1", "1000.0000");
        }

        if (material.FindToken("$TEXTURE"))
        {
            var biome = GetBiome(script);
            var overlayPath = GetDefaultTextureForBiome(biome);

            material.ReadValue<string>(1);
            material.RemoveSelection();
            material.Prepend("$TEXTURE", 5, overlayPath);
        }

        try
        {
            File.WriteAllText(scriptPath, script.ScriptContent);
            File.WriteAllText(materialPath, material.ScriptContent);
        }
        catch { }
    }

    private Biome GetBiome(Script script)
    {
        return
            script.FindToken("$TYPE_SIBERIA") ? Biome.Siberia :
            script.FindToken("$TYPE_DESERT") ? Biome.Desert :
            script.FindToken("$TYPE_JUNGLE") ? Biome.Jungle :
            Biome.Classic;
    }

    private string GetDefaultTextureForBiome(Biome biome)
    {
        return biome switch
        {
            Biome.Classic => "tiles_normal/grass2.dds",
            Biome.Siberia => "dlc2/tiles_siberia/grass2.dds",
            Biome.Desert => "dlc2/tiles_middleeast/newdesert1d.dds",
            Biome.Jungle => "dlc2/tiles_asia/jungle_swamp_dm.dds",
            _ => throw new InvalidDataException("Invalid biome")
        };
    }

    public static bool IsValidGameSave(string path)
    {
        return RequiredFiles.All(file =>
            Path.Exists(Path.Combine(path, file)));
    }
}