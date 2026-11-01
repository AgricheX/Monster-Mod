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

namespace Monster
{
    class Monsters
    {
        public static void init(){
          create_Godzilla();
          create_KingKong();
        }
          //Godzilla
          public static void create_Godzilla(){
          var Godzilla = AssetManager.unitStats.clone("Godzilla", "_mob");
          Godzilla.nameLocale = "Godzilla";
          Godzilla.nameTemplate = "Godzilla_name";
          Godzilla.race = "GodzillaRace";
          Godzilla.kingdom = "GodzillaRace";
          Godzilla.maxAge = 1000000;
          Godzilla.baseStats.knockbackReduction = 10000f;
          Godzilla.baseStats.damageCritMod = 100f;
          Godzilla.baseStats.attackSpeed = 50f;
          Godzilla.baseStats.areaOfEffect = 15f;
          Godzilla.baseStats.knockback = 3f;
          Godzilla.baseStats.accuracy = 1000f;
          Godzilla.baseStats.health = 50000;
          Godzilla.baseStats.speed = 50f;
          Godzilla.baseStats.damage = 1000;
          Godzilla.baseStats.targets = 10;
          Godzilla.baseStats.range = 15f;
          Godzilla.baseStats.dodge = 0f;
          Godzilla.baseStats.armor = 10;
          Godzilla.canBeKilledByDivineLight = false;
          Godzilla.canBeKilledByLifeEraser = true;
          Godzilla.ignoredByInfinityCoin = false;
          Godzilla.disableJumpAnimation = true;
          Godzilla.canBeMovedByPowers = true;
          Godzilla.canTurnIntoZombie = false;
          Godzilla.canAttackBuildings = true;
          Godzilla.hideFavoriteIcon = true;
          Godzilla.can_edit_traits = false;
          Godzilla.very_high_flyer = false;
          Godzilla.damagedByOcean = false;
          Godzilla.damagedByRain = false;
          Godzilla.swampCreature = true;
          Godzilla.oceanCreature = true;
          Godzilla.swimToIsland = true;
          Godzilla.landCreature = true;
          Godzilla.dieOnGround = false;
          Godzilla.take_items = false;
          Godzilla.use_items = false;
          Godzilla.diet_meat = false;
          Godzilla.have_soul = true;
		      Godzilla.dieInLava = false;
          Godzilla.needFood = false;
          Godzilla.flying = false;
          Godzilla.hideOnMinimap = false;
          Godzilla.actorSize = ActorSize.S17_Dragon;
          Godzilla.animation_walk = "walk_0,walk_1,walk_2,walk_3";
          Godzilla.animation_swim = "swim_0,swim_1";
          Godzilla.texture_path = "Godzilla";
          Godzilla.icon = "iconGodzilla";
          Godzilla.job = "attacker";
          AssetManager.unitStats.add(Godzilla);
          AssetManager.unitStats.CallMethod("loadShadow", Godzilla);
          AssetManager.unitStats.CallMethod("addTrait", "Godzilla Power");
          Localization.addLocalization(Godzilla.nameLocale, Godzilla.nameLocale);
          }

          //KingKong
          public static void create_KingKong(){
          var KingKong = AssetManager.unitStats.clone("KingKong", "_mob");
          KingKong.nameLocale = "KingKong";
          KingKong.nameTemplate = "KingKong_name";
          KingKong.race = "KingKongRace";
          KingKong.kingdom = "monkeys";
          KingKong.maxAge = 1000000;
          KingKong.baseStats.knockbackReduction = 10000f;
          KingKong.baseStats.damageCritMod = 100f;
          KingKong.baseStats.attackSpeed = 70f;
          KingKong.baseStats.areaOfEffect = 10f;
          KingKong.baseStats.knockback = 3f;
          KingKong.baseStats.accuracy = 1000f;
          KingKong.baseStats.health = 10000;
          KingKong.baseStats.speed = 70f;
          KingKong.baseStats.damage = 1000;
          KingKong.baseStats.targets = 5;
          KingKong.baseStats.range = 5f;
          KingKong.baseStats.dodge = 0f;
          KingKong.baseStats.armor = 50;
          KingKong.canBeKilledByDivineLight = false;
          KingKong.canBeKilledByLifeEraser = true;
          KingKong.ignoredByInfinityCoin = false;
          KingKong.disableJumpAnimation = true;
          KingKong.canBeMovedByPowers = true;
          KingKong.canTurnIntoZombie = false;
          KingKong.canAttackBuildings = true;
          KingKong.hideFavoriteIcon = true;
          KingKong.can_edit_traits = false;
          KingKong.very_high_flyer = false;
          KingKong.damagedByOcean = false;
          KingKong.damagedByRain = false;
          KingKong.swampCreature = false;
          KingKong.oceanCreature = false;
          KingKong.swimToIsland = true;
          KingKong.landCreature = true;
          KingKong.dieOnGround = false;
          KingKong.take_items = false;
          KingKong.use_items = false;
          KingKong.diet_meat = false;
          KingKong.have_soul = true;
		      KingKong.dieInLava = true;
          KingKong.needFood = false;
          KingKong.flying = false;
          KingKong.hideOnMinimap = false;
          KingKong.actorSize = ActorSize.S17_Dragon;
          KingKong.animation_walk = "walk_0,walk_1,walk_2,walk_3";
          KingKong.animation_swim = "swim_0,swim_1,swim_2,swim_3";
          KingKong.texture_path = "KingKong";
          KingKong.icon = "iconKingKong";
          KingKong.job = "attacker";
          AssetManager.unitStats.add(KingKong);
          AssetManager.unitStats.CallMethod("loadShadow", KingKong);
          AssetManager.unitStats.CallMethod("addTrait", "KingKong Power");
          AssetManager.unitStats.CallMethod("addTrait", "regeneration");
          AssetManager.unitStats.CallMethod("addTrait", "genius");
          AssetManager.unitStats.CallMethod("addTrait", "strong");
          AssetManager.unitStats.CallMethod("addTrait", "tough");
          Localization.addLocalization(KingKong.nameLocale, KingKong.nameLocale);

          //Kingdoms
          KingdomAsset GodzillaRaceKingdom = new KingdomAsset();
          GodzillaRaceKingdom.id = "GodzillaRace";
          GodzillaRaceKingdom.mobs = true;
          GodzillaRaceKingdom.addTag("GodzillaRace");
          GodzillaRaceKingdom.addFriendlyTag("GodzillaRace");
          GodzillaRaceKingdom.addEnemyTag("nature_creature");
          GodzillaRaceKingdom.addEnemyTag("civ");
          AssetManager.kingdoms.add(GodzillaRaceKingdom);
          MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", GodzillaRaceKingdom);

          KingdomAsset KingKongRaceKingdom = new KingdomAsset();
          KingKongRaceKingdom.id = "KingKongRace";
          KingKongRaceKingdom.mobs = true;
          KingKongRaceKingdom.addTag("KingKongRace");
          KingKongRaceKingdom.addFriendlyTag("KingKongRace");
          KingKongRaceKingdom.addFriendlyTag("nature_creature");
          KingKongRaceKingdom.addEnemyTag("GodzillaRace");
          KingKongRaceKingdom.addEnemyTag("civ");
          AssetManager.kingdoms.add(KingKongRaceKingdom);
          MapBox.instance.kingdoms.CallMethod("newHiddenKingdom", KingKongRaceKingdom);

          //Names
          NameGeneratorAsset GodzillaName = new NameGeneratorAsset();
          GodzillaName.id = "Godzilla_name";
          GodzillaName.part_groups.Add("Godzilla");
          GodzillaName.templates.Add("part_group");
          AssetManager.nameGenerator.add(GodzillaName);

          NameGeneratorAsset KingKongName = new NameGeneratorAsset();
          KingKongName.id = "KingKong_name";
          KingKongName.part_groups.Add("King Kong");
          KingKongName.templates.Add("part_group");
          AssetManager.nameGenerator.add(KingKongName);

          }
    }
}