using Assets.Sources.SceneDataLogic;
using System;
using System.Collections;
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
        [SerializeField] private SpriteColorConfig[] _nonBuildedConfigs;
        [SerializeField] private SpriteColorConfig[] _buildedConfigs;

        [Space]

        [SerializeField] private HouseBehaviour _houseBehaviour;

        [Space]

        [SerializeField] private SceneData _sceneData;

        private void Awake()
        {
            SpriteColorConfig[] configs = _houseBehaviour.Builded ? _buildedConfigs : _nonBuildedConfigs;

            foreach (var config in configs)
            {
                config.SpriteRenderer.color = config.Color;
            }
        }

        public void LoadScene()
        {
            if (_houseBehaviour.Builded) return;

            _sceneData.HouseBehaviour = _houseBehaviour;

            SceneManager.LoadScene("HouseBuildingScene");
        }
    }
}