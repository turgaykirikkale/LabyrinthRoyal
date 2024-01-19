using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GettingHealth : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TMP_Text _healthCount, _infoModalText;
    [SerializeField] GameObject _healthButton, _infoModal;
    int _count = 2 + HealthCountManager._amount; //PlayerPrefabstan Alacagız.

    void Start()
    {
        _healthCount.text = "x" + _count.ToString();
        _infoModalText.text = "You dont have enough health";
    }

    public void AddingHealth()
    {

        if (Health._currentHealth >= 100)
        {
            LeanTween.scale(_infoModal, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(closeInfoModal);
            _infoModalText.text = "Your health is full";
        }
        else
        {
            _count -= 1;
            if (_count < 0)
            {
                LeanTween.scale(_infoModal, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(closeInfoModal);

            }
            else
            {
                HealthCountManager.DecreaseAmount(1);
                Health.Heal(5f);
                _healthCount.text = "x" + _count.ToString();
            }

        }

    }

    public void closeInfoModal()
    {
        LeanTween.scale(_infoModal, new Vector3(0f, 0f, 0f), 1f).setDelay(1f).setEase(LeanTweenType.easeOutCubic);

    }
}
