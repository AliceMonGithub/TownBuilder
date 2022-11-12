using Assets.Sources.SceneDataLogic;
using Lean.Transition;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Sources.House
{
    [Serializable]
    public class SpriteColorConfig
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Color _color;

        public SpriteRenderer SpriteRenderer => _spriteRenderer;
        public Color Color => _color;
    }

    public class HousePiece : MonoBehaviour
    {
        [SerializeField] private GameObject _nonBuildedGO;

        [Space]

        [SerializeField] private HouseBehaviour _houseBehaviour;

        [Space]

        [SerializeField] private SceneData _sceneData;

        private void Awake()
        {
            bool builded = _sceneData.Houses.Any(house => house == _houseBehaviour);

            _nonBuildedGO.SetActive(!builded);
        }

        public void LoadScene()
        {
            if (_sceneData.Houses.Any(house => house == _houseBehaviour)) return;

            _sceneData.HouseBehaviour = _houseBehaviour;

            SceneManager.LoadScene("HouseBuildingScene");
        }
    }
}