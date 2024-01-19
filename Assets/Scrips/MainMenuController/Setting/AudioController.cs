using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AudiController : MonoBehaviour, IPointerDownHandler
{

    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _closedAudio;
    bool _isClosed = false;
    // Start is called before the first frame update

    public void OnPointerDown(PointerEventData eventData)
    {
        _isClosed = !_isClosed;
        if (_isClosed)
        {
            this._img.sprite = _closedAudio;
            //  _source.PlayOneShot(this._compressedClip);
            // Audio will stop;
            Debug.Log("AUDIOO");
        }
        else
        {
            this._img.sprite = _default;
            //audiowill start;
        }



    }



}
