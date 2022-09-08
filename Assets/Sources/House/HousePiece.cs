using Assets.Sources.SceneDataLogic;
using System.Collections;
using UnityEngine;

namespace Assets.Sources.House
{
    public class HousePiece : MonoBehaviour
    {
        [SerializeField] private HouseBehaviour _houseBehaviour;

        [Space]

        [SerializeField] private SceneData _sceneData;

        public void LoadScene()
        {
            _sceneData.HouseBehaviour = _houseBehaviour;

            _sceneData.Finished = false;
        }
    }
}