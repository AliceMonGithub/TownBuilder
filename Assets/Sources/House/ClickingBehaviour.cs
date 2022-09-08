using Assets.Sources.SceneDataLogic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Assets.Sources.House
{
    public class ClickingBehaviour : MonoBehaviour
    {
        [SerializeField] private TMP_Text _moneyCount;
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
            _houseBehaviour.ClickCount++;

            _sceneData.Money += _houseBehaviour.ClickMoney;

            InstantiateParticle(pointerData.pointerClick.transform.position);

            Render();

            if(_houseBehaviour.ClickCount >= _houseBehaviour.ClicksToBuild)
            {
                _houseBehaviour.Builded = true;

                SceneManager.LoadScene("TownScene");

                _sceneData.Money += _houseBehaviour.BuildMoney;
            }
        }

        private void InstantiateParticle(Vector3 position)
        {
            Instantiate(_particleSystem, position, Quaternion.identity);
        }

        private void Render()
        {
            _moneyCount.text = _sceneData.Money.ToString();
        }
    }
}