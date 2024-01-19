using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update

    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    // [SerializeField] private AudioClip _compressedClip, _unCompressedClip;
    // [SerializeField] private AudioSource _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        this._img.sprite = _pressed;
        //  _source.PlayOneShot(this._compressedClip);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this._img.sprite = _default;
        // _source.PlayOneShot(this._unCompressedClip);
    }

    public void pressedButton()
    {
        // Debug.Log(selectedImage.sprite);
        Debug.Log("PreesedLogin Button");
    }
}
