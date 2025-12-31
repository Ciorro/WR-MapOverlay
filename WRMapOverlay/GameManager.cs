using RepublicTK.Scripts;

namespace WRMapOverlay;

public class GameManager
{
    const string GameExecutableFileName = "SOVIET.exe";

    public event Action<string>? GameDirectoryChanged;
    public string? GameDirectoryRoot { get; private set; }

    public void SetGameDirectoryRoot(string gameDirectoryRoot)
    {
        if (!Directory.Exists(gameDirectoryRoot))
        {
            throw new ArgumentException($"\"{gameDirectoryRoot}\" is not a valid directory.");
        }

        var directoryFiles = Directory.GetFiles(gameDirectoryRoot)
            .Select(Path.GetFileName);

        if (!directoryFiles.Contains(GameExecutableFileName))
        {
            throw new ArgumentException($"\"{gameDirectoryRoot}\" is not a valid game directory.");
        }

        GameDirectoryRoot = gameDirectoryRoot;
        GameDirectoryChanged?.Invoke(gameDirectoryRoot);
    }

    public IEnumerable<GameSave> GetGameSaves()
    {
        var saveTerrainEditorPath = GetOrCreateSubdirectory("save_terraineditor");

        if (Path.Exists(saveTerrainEditorPath))
        {
            var directories = Directory.GetDirectories(saveTerrainEditorPath);

            return directories
                .Where(GameSave.IsValidGameSave)
                .Select(dir => new GameSave(dir))
                .ToList();
        }

        return [];
    }

    public int GetTerrainDepthSetting()
    {
        var configPath = Path.Combine(GetOrCreateSubdirectory(""), "config.ini");
        var config = new Script(File.ReadAllText(configPath));

        while (config.FindNextToken("$INT"))
        {
            if (config.ReadValue<string>() == "GRAPHIC_TERRAINDETAIL")
            {
                return config.ReadValue<int>();
            }
        }

        return -1;
    }

    public string GetOrCreateSubdirectory(string subdirectory)
    {
        if (string.IsNullOrWhiteSpace(GameDirectoryRoot))
        {
            throw new InvalidOperationException("Game directory root is invalid.");
        }

        var directory = Path.Combine(
            GameDirectoryRoot,
            "media_soviet",
            subdirectory);

        if (!Directory.Exists(directory))
        {
            Console.WriteLine($"Creating: \"{directory}\"");
            Directory.CreateDirectory(directory);
        }

        return directory;
    }
}
