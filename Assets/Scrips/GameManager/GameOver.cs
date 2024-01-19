using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _gameOverScreen;
    [SerializeField] GameObject _moveJoys, _cameraJoys, _healtBar, _countUp, _mapButton, _healthButton, _coinButton, _timeButton;
    [SerializeField] TMP_Text _mainMenuText, _tryAgain;

    public static bool isGameOver = false;


    void Start()
    {
        _mainMenuText.text = "MENU";
        _tryAgain.text = "RESTART";
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            _gameOverScreen.SetActive(true);
            _moveJoys.SetActive(false);
            _cameraJoys.SetActive(false);
            _healtBar.SetActive(false);
            _countUp.SetActive(false);
            _mapButton.SetActive(false);
            _healthButton.SetActive(false);
            _coinButton.SetActive(false);
            _timeButton.SetActive(false);
            Time.timeScale = 0;
        }
    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        TakingKey._isTakedKey = false;
        isGameOver = false;
        Health._currentHealth = 100;
        Health.isGameOver = false;
        GameDownCounter.timer = 15; //Level Timer'ı gelecek
        CoinCounter.count = 0f;
        SwitchToLevel.SwitchToSceneByIndex(ControllScrollItems.inLevel);

    }
    public void MainMenuButton()
    {
        Time.timeScale = 1;
        FinishManager._isFinish = false;
        TakingKey._isTakedKey = false;
        isGameOver = false;
        Health._currentHealth = 100;
        Health.isGameOver = false;
        GameDownCounter.timer = 15; //Level Timer'ı gelecek
        CoinCounter.count = 0f;
        SwitchToLevel.SwitchToSceneByIndex(0);



    }
}
