using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Sources.SceneDataLogic
{
    [CreateAssetMenu]
    public class SceneData : ScriptableObject
    {
        public int Money;

        [Space]

        public List<HouseBehaviour> Houses;
        public HouseBehaviour HouseBehaviour;
    }
}