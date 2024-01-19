using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenExitDoor : MonoBehaviour
{
    [SerializeField] Transform _exitDoor;
    [SerializeField] GameObject _keyInfoModal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && TakingKey._isTakedKey)
        {
            Sequence seq = DOTween.Sequence();
            seq.Append(_exitDoor.DOMoveY(5.1f, 1.5f));
        }
        else
        {
            _keyInfoModal.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _keyInfoModal.SetActive(false);
        }
    }
}
