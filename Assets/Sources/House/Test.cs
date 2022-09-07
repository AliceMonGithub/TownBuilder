using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Sources.House
{
    public class Test : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            print("Test");
        }
    }
}