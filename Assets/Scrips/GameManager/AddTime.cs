using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text _timeCount, _infoModalText;
    [SerializeField] GameObject _timeButton, _infoModal;
    int _count = 2 + TimeCountManager._amount; //PlayerPrefabstan Alacagız.
    void Awake()
    {
        _timeCount.text = "x" + _count.ToString();
        _infoModalText.text = "You dont have enough time";
    }

    public void AddingTime()
    {
        _count -= 1;
        if (_count < 0)
        {
            LeanTween.scale(_infoModal, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(closeInfoModal);

        }
        else
        {
            if (GameDownCounter.timer > 0)
            {
                TimeCountManager.DecreaseAmount(1);
                Debug.Log("TimeCountManager._amount" + TimeCountManager._amount);
                GameDownCounter.timer += 5;
                _timeCount.text = "x" + _count.ToString();
            }
            else
            {
                Debug.Log("Time is zeroo");
            }
        }
    }

    public void closeInfoModal()
    {
        LeanTween.scale(_infoModal, new Vector3(0f, 0f, 0f), 1f).setDelay(1f).setEase(LeanTweenType.easeOutCubic);

    }
}
