using System.Collections.Generic;
using System.IO;
using MelonLoader;
using Tomlet;
using Tomlet.Attributes;

namespace CustomHitSound;

internal class Main : MelonMod
{
    internal static Dictionary<string, string[]> Paths { get; } = new();

    public override void OnInitializeMelon()
    {
        Save.Load();
        var folders = Directory.GetDirectories(Path.Combine("UserData", "BattleSfx"));
        foreach (var folder in folders)
        {
            var key = folder.Remove(0, 19);
            Paths.Add(key, Directory.GetFiles(folder));
        }
    }

    public override void OnDeinitializeMelon()
    {
        if (!Paths.ContainsKey(Save.Setting.Sfx))
            Save.Setting.Sfx = string.Empty;
        File.WriteAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"), TomletMain.TomlStringFrom(Save.Setting));
    }
}

internal static class Save
{
    private static readonly Data Default = new("Celeste", false);
    internal static Data Setting;

    public static void Load()
    {
        if (!File.Exists(Path.Combine("UserData", "Custom Hit Sound.cfg")))
        {
            var defaultConfig = TomletMain.TomlStringFrom(Default);
            File.WriteAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"), defaultConfig);
        }

        var data = File.ReadAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"));
        Setting = TomletMain.To<Data>(data);
    }

    internal struct Data
    {
        [TomlPrecedingComment("The current using sfx pack")]
        internal string Sfx { get; set; }

        [TomlPrecedingComment("Whether debug mode enabled or not")]
        internal bool DebugModeEnabled { get; set; }

        internal Data(string sfx, bool debugModeEnabled)
        {
            Sfx = sfx;
            DebugModeEnabled = debugModeEnabled;
        }
    }
}