using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RP.SoundManager
{
    [CreateAssetMenu(fileName = "SoundData", menuName = "ScriptableObjects/SoundManagerData", order = 1)]
    public class SoundData : ScriptableObject
    {
        public List<AudioControl> audioControls = new List<AudioControl>();
    }

    [Serializable]
    public struct AudioControl
    {
        public string name;
        public AudioClip audioclip;
        public Audio audio;
    }

}
