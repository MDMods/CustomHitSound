using System.Collections.Generic;
using System.IO;
using MelonLoader;
using UnityEngine.UI;

namespace CustomHitSound;

internal class Main : MelonMod
{
    internal static Dictionary<string, string[]> Paths { get; } = new();
    internal static Dictionary<string, Toggle> Toggles { get; } = new();

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
        if (!Paths.ContainsKey(Save.Sfx))
            Save.Sfx = string.Empty;
        File.WriteAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"), Save.Sfx);
    }
}

internal static class Save
{
    private const string Default = "Celeste";
    internal static string Sfx { get; set; }

    public static void Load()
    {
        if (!File.Exists(Path.Combine("UserData", "Custom Hit Sound.cfg")))
            File.WriteAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"), Default);

        Sfx = File.ReadAllText(Path.Combine("UserData", "Custom Hit Sound.cfg"));
    }
}