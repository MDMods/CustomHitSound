using System;
using System.IO;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using HarmonyLib;
using RuntimeAudioClipLoader;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace CustomHitSound;

[HarmonyPatch(typeof(AudioManager), "PreloadBattleSfx")]
internal static class AudioManagerPatch
{
    private static void Postfix(AudioManager __instance)
    {
        if (!Main.Toggles.TryGetValue(Save.Sfx, out var toggle) || !toggle.isOn)
        {
            Save.Sfx = string.Empty;
            return;
        }

        foreach (var path in Main.Paths[Save.Sfx])
        {
            var postfix = "_" + Save.Sfx.ToLower();
            var name = Path.GetFileNameWithoutExtension(path).Replace(postfix, string.Empty);
            var audioClip = Manager.Load(path);
            __instance.m_SfxBuffer[name] = audioClip;
        }
    }
}

[HarmonyPatch(typeof(VolumeSelect), "SetSelectableObj")]
internal static class VolumeSelectPatch
{
    private static void Postfix()
    {
        Main.Toggles.Clear();
        var toggles = GameObject.Find("Forward").transform.GetChild(5).GetChild(6).GetChild(2);
        var x = -6.35f;
        foreach (var key in Main.Paths.Keys)
        {
            var toggle = Object.Instantiate(toggles.GetChild(0).gameObject, toggles.transform);
            toggle.name = "Tgl" + key;
            toggle.transform.position = new Vector3(x, -3.65f, 100);

            var text = toggle.transform.GetChild(1).GetComponent<Text>();
            text.text = key;

            var toggleComp = toggle.GetComponent<Toggle>();
            toggleComp.onValueChanged.AddListener((Action<bool>)(val =>
            {
                if (val)
                {
                    DataHelper.battleSfxType = 0;
                    Save.Sfx = key;
                }
            }));

            if (Save.Sfx == key)
                toggleComp.SetIsOnWithoutNotify(true);

            Main.Toggles.Add(key, toggleComp);
            x += 1f + key.Length * 0.2f;
        }

        if (Save.Sfx == string.Empty && DataHelper.battleSfxType == 0)
            toggles.GetChild(0).GetComponent<Toggle>().SetIsOnWithoutNotify(true);
    }
}