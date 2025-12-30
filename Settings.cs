using System.Reflection;

namespace WRMapOverlay;

public class Settings
{
    const string SettingsFileName = "wrmapoverlay.ini";

    public string GameDirectory
    {
        get;
        set
        {
            field = value;
            Save();
        }
    } = "";

    public void Load()
    {
        string path = GetSettingsPath();
        if (File.Exists(path))
        {
            GameDirectory = File.ReadAllText(path);
        }
    }

    public void Save()
    {
        File.WriteAllText(GetSettingsPath(), GameDirectory);
    }

    private string GetSettingsPath()
    {
        string assemblyLocation = Path.GetDirectoryName(
            AppContext.BaseDirectory)!;
        return Path.Combine(assemblyLocation, SettingsFileName);
    }
}
