using System;
using System.Threading;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ai;

namespace Monster
{
    class MonstersTraits
    {
        //Traits
        public static void init()
        {
         //Godzilla Power
         ActorTrait GodzillaPower = new ActorTrait();
         GodzillaPower.id = "Godzilla Power";
         GodzillaPower.path_icon = "ui/Traitss/iconGodzillaPower";
         GodzillaPower.can_be_given = false;
         GodzillaPower.action_attack_self = (WorldAction)Delegate.Combine(GodzillaPower.action_attack_self, new WorldAction(GodzillaPower1));
         GodzillaPower.action_special_effect = (WorldAction)Delegate.Combine(GodzillaPower.action_special_effect, new WorldAction(GodzillaPower2));
         GodzillaPower.action_attack_target = (WorldAction)Delegate.Combine(GodzillaPower.action_attack_target, new WorldAction(GodzillaPower3));
         AssetManager.traits.add(GodzillaPower);
         addTraitToLocalizedLibrary(GodzillaPower.id, "The Godzilla Power.");
         PlayerConfig.unlockTrait("Godzilla Power");

         //KingKong Power
         ActorTrait KingKongPower = new ActorTrait();
         KingKongPower.id = "KingKong Power";
         KingKongPower.path_icon = "ui/Traitss/iconKingKongPower";
         KingKongPower.can_be_given = false;
         KingKongPower.action_attack_self = (WorldAction)Delegate.Combine(KingKongPower.action_attack_self, new WorldAction(KingKongPower1));
         AssetManager.traits.add(KingKongPower);
         addTraitToLocalizedLibrary(KingKongPower.id, "The King Kong Power.");
         PlayerConfig.unlockTrait("KingKong Power");

         //Godzilla Power Effects
         }
        public static bool GodzillaPower1(BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
          if(Toolbox.randomChance(0.5f)){
          MapBox.instance.applyForce(pTile, 10, 0.5f, true, false, 3, null, null, null);
          }
        }
      		return true;

          }
        public static bool GodzillaPower2(BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
          if(Toolbox.randomChance(0.001f)){
          MapBox.instance.earthquakeManager.startQuake(pTile, EarthquakeType.RandomPower);
          MapBox.instance.applyForce(pTile, 10, 0.5f, true, false, 3, null, null, null);
          }
        }
      		return true;

          }
        public static bool GodzillaPower3(BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
          if(Toolbox.randomChance(0.01f)){
          ActionLibrary.deathNuke(pTarget, pTile);
          MapBox.instance.startShake(0.3f, 0.01f, 2f, true, true);
		      MapBox.instance.stackEffects.spawnNukeFlash(pTile, "atomicBomb");
          }
        }
      		return true;

         }
        public static bool KingKongPower1(BaseSimObject pTarget, WorldTile pTile = null) 
      	{
          if(pTarget != null){
          Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
          if(Toolbox.randomChance(0.5f)){
          MapBox.instance.applyForce(pTile, 10, 0.5f, true, false, 3, null, null, null);
          }
        }
      		return true;

            //Boring

            }
        public static void addTraitToLocalizedLibrary(string id, string description)
      	{
      		string language = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "language") as string;
      		Dictionary<string, string> localizedText = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as Dictionary<string, string>;
      		localizedText.Add("trait_" + id, id);
      		localizedText.Add("trait_" + id + "_info", description);
        }
    }
}