using System.Collections;
using UnityEngine;

namespace Assets.Sources.SceneDataLogic
{
    [CreateAssetMenu]
    public class SceneData : ScriptableObject
    {
        public HouseBehaviour HouseBehaviour;
        public bool Finished;
    }
}