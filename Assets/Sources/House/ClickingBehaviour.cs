using Assets.Sources.SceneDataLogic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Sources.House
{
    public class ClickingBehaviour : MonoBehaviour
    {
        [SerializeField] private TMP_Text _clickCount;
        [SerializeField] private ParticleSystem _particleSystem;

        [Space]

        [SerializeField] private SceneData _sceneData;
        [SerializeField] private Pointer _pointer;

        private HouseBehaviour _houseBehaviour;

        private void Awake()
        {
            _houseBehaviour = _sceneData.HouseBehaviour;
            _pointer.PointerClicked += PointerClick;

            Render();
        }

        private void PointerClick(PointerEventData pointerData)
        {
            InstantiateParticle(Camera.main.ViewportToWorldPoint(pointerData.position));

            Render();
        }

        private void InstantiateParticle(Vector3 position)
        {
            Instantiate(_particleSystem, position, Quaternion.identity);
        }

        private void Render()
        {
            _clickCount.text = Mathf.Clamp(_houseBehaviour.ClicksToBuild - _houseBehaviour.ClickCount, 0, float.MaxValue).ToString();
        }
    }
}