using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TMP_Text _locationCount, _infoModalText, _homeButtonText, _StartButtonText;
    [SerializeField] GameObject _locationButton, _infoModal, _homeButton, _startButton, _closeButton, _movingJoystick, _camJoystick, _mapButton, _timeButton, _healthButton;
    [SerializeField] GameObject _map;
    int _count = 2 + LocationCountManager._amount; //Prefabstan alınacak.
    public static bool isFromStarting = true;

    void Start()
    {
        _locationCount.text = "x" + _count.ToString();
        _infoModalText.text = "You dont have enough map";
        _homeButtonText.text = "MENU";
        _StartButtonText.text = "START";
        GameDownCounter._gameCounting = false;
        StartCounter.isCounting = false;
        _closeButton.SetActive(false);
        _movingJoystick.SetActive(false);
        _camJoystick.SetActive(false);
        _mapButton.SetActive(false);
        _timeButton.SetActive(false);
        _healthButton.SetActive(false);


    }



    public void showPositionMap()
    {


        _count -= 1;
        if (_count < 0)
        {
            LeanTween.scale(_infoModal, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(closeInfoModal);

        }
        else
        {
            if (isFromStarting)
            {
                isFromStarting = false;
            }

            _map.SetActive(true);
            _movingJoystick.SetActive(false);
            _camJoystick.SetActive(false);
            _mapButton.SetActive(false);
            _timeButton.SetActive(false);
            _healthButton.SetActive(false);
            GameDownCounter._gameCounting = false;
            StartCounter.isCounting = false;
        }


    }

    public void closeInfoModal()
    {
        LeanTween.scale(_infoModal, new Vector3(0f, 0f, 0f), 1f).setDelay(1f).setEase(LeanTweenType.easeOutCubic);

    }

    public void closeMap()
    {
        LocationCountManager.DecreaseAmount(1);
        _locationCount.text = "x" + _count.ToString();
        _map.SetActive(false);
        _movingJoystick.SetActive(true);
        _camJoystick.SetActive(true);
        _mapButton.SetActive(true);
        _timeButton.SetActive(true);
        _healthButton.SetActive(true);


        StartCounter.isCounting = true;
    }

    public void HomeButton()
    {
        SwitchToLevel.SwitchToSceneByIndex(0);
    }

    public void StartButton()
    {

        isFromStarting = false;
        _map.SetActive(false);
        _homeButton.SetActive(false);
        _startButton.SetActive(false);
        _closeButton.SetActive(true);
        StartCounter.isCounting = true;
        _movingJoystick.SetActive(true);
        _camJoystick.SetActive(true);
        _mapButton.SetActive(true);
        _timeButton.SetActive(true);
        _healthButton.SetActive(true);


    }
}
