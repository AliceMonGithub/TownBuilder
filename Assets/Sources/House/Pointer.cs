using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Sources.House
{
    public class Pointer : MonoBehaviour, IPointerClickHandler
    {
        public event Action<PointerEventData> PointerClicked;

        public void OnPointerClick(PointerEventData eventData)
        {
            PointerClicked?.Invoke(eventData);
        }
    }
}