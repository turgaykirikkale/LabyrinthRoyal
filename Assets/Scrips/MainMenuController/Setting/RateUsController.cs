using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RateUsController : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Rate Us");
    }

}
