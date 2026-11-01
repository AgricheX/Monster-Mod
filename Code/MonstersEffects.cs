using System;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;

namespace Monster
{
    class MonstersEffects
    {
        public static void init()
        {
          
          //Self
          StatusEffect GodzillaEffect = new StatusEffect();
		  GodzillaEffect.id = "GodzillaEffect";
		  GodzillaEffect.texture = "GodzillaEffect";
		  GodzillaEffect.animated = true;
		  GodzillaEffect.animation_speed = 0.1f;
          GodzillaEffect.baseStats.armor = 50;
          GodzillaEffect.baseStats.damage = 1000;
		  GodzillaEffect.duration = 1f;
          GodzillaEffect.removeStatus.Add("burning");
		  GodzillaEffect.oppositeStatus.Add("frozen");
		  AssetManager.status.add(GodzillaEffect);

        }
    }
}