using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Reflection;
using Newtonsoft.Json;

namespace Monster
{
    class MonstersButtons
    {
        public static void init()
        {
            //Godzilla
            #region Godzilla

            var Godzilla = new GodPower();
            Godzilla.id = "spawnGodzilla";
            Godzilla.showSpawnEffect = "spawn";
            Godzilla.actorSpawnHeight = 3f;
            Godzilla.name = "spawnGodzilla";
            Godzilla.spawnSound = "spawnelf";
            Godzilla.actorStatsId = "Godzilla";
            Godzilla.click_action = new PowerActionWithID((WorldTile pTile, string pPower) => { return (bool)AssetManager.powers.CallMethod("spawnUnit", pTile, pPower); });
            AssetManager.powers.add(Godzilla);

            var buttonGodzilla = NCMS.Utils.PowerButtons.CreateButton(
            "spawnGodzilla",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconGodzilla.png"),
            "The Kaiju - Godzilla",
            "The King Of Monsters",
            new Vector2(72, 18),
            ButtonType.GodPower,
            MonstersTab.additionalPowersTab.transform,
            null
            );

            #endregion

            //KingKong
            #region KingKong

            var KingKong = new GodPower();
            KingKong.id = "spawnKingKong";
            KingKong.showSpawnEffect = "spawn";
            KingKong.actorSpawnHeight = 3f;
            KingKong.name = "spawnKingKong";
            KingKong.spawnSound = "spawnelf";
            KingKong.actorStatsId = "KingKong";
            KingKong.click_action = new PowerActionWithID((WorldTile pTile, string pPower) => { return (bool)AssetManager.powers.CallMethod("spawnUnit", pTile, pPower); });
            AssetManager.powers.add(KingKong);

            var buttonKingKong = NCMS.Utils.PowerButtons.CreateButton(
            "spawnKingKong",
            Mod.EmbededResources.LoadSprite($"{Mod.Info.Name}.Resources.units.iconKingKong.png"),
            "The Kaiju - King Kong",
            "The King Kong",
            new Vector2(72, -18),
            ButtonType.GodPower,
            MonstersTab.additionalPowersTab.transform,
            null
            );

            #endregion
        }
    }
}