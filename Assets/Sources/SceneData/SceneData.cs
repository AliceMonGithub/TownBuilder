using System.Collections;
using UnityEngine;

namespace Assets.Sources.SceneDataLogic
{
    [CreateAssetMenu]
    public class SceneData : ScriptableObject
    {
        public int Money;

        [Space]

        public HouseBehaviour HouseBehaviour;
    }
}