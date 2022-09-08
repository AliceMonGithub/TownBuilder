using System;
using UnityEngine;
using UnityEngine.Events;

namespace SceneLogic
{
    public class LoadCurtain : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onLoadingStart;
        [SerializeField] private UnityEvent _onLoadingFinish;

        public readonly SceneLoader SceneLoader = new SceneLoader();

        private string _sceneName;

        public Action OnHideEvent;

        public string CurrentSceneName => SceneLoader.CurrentSceneName;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void LoadScene(string sceneName)
        {
            _sceneName = sceneName;

            _onLoadingStart.Invoke();
        }

        public void Load()
        {
            SceneLoader.LoadScene(_sceneName, _onLoadingFinish.Invoke);
        }

        public void OnHide()
        {
            OnHideEvent?.Invoke();
        }
    }
}