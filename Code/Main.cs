using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NCMS.Utils;
using UnityEngine;
using NCMS;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monster{
    [ModEntry]
    class Mody : MonoBehaviour{
        void Awake(){
            MonstersTab.init();
            Monsters.init();
            MonstersTraits.init();
            MonstersEffects.init();
            MonstersButtons.init();
        }
    }
}