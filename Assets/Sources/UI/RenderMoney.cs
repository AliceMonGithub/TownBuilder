using Assets.Sources.SceneDataLogic;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Sources.UI
{
    public class RenderMoney : MonoBehaviour
    {
        [SerializeField] private TMP_Text _moneyText;
        [SerializeField] private SceneData _sceneData;

        private void Awake()
        {
            _moneyText.text = _sceneData.Money.ToString();
        }
    }
}