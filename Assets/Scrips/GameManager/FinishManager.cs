using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _gameFinishBox, _backPanel, _levelSuccess, _coins, _homeButton, _nextLevelButton, _leftStar, _middleStar, rightStar;

    [SerializeField] TMP_Text _coinCount;
    public static bool _isFinish = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameDownCounter._gameCounting = false;
            _isFinish = true;
            _gameFinishBox.SetActive(true);
            _coinCount.text = "+" + CoinCounter.count.ToString() + "  Coins";
            LeanTween.scale(_levelSuccess, new Vector3(1.3f, 1.3f, 1.3f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(levelComplete);
            LeanTween.moveLocal(_levelSuccess, new Vector3(0f, 148f, 0f), .7f).setDelay(2f).setEase(LeanTweenType.easeOutCubic);
            LeanTween.scale(_levelSuccess, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeOutCubic);
        }
    }

    void levelComplete()
    {
        LeanTween.moveLocal(_backPanel, new Vector3(0f, 0f, 0f), 0.5f).setDelay(0.3f).setEase(LeanTweenType.easeOutCirc).setOnComplete(starsAnim);
    }
    void starsAnim()
    {
        //Buradaki yıldız zamana göre ve levele göre belirlenecek!!!!!
        LeanTween.scale(_leftStar, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(_middleStar, new Vector3(1f, 1f, 1f), 1f).setDelay(.4f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(rightStar, new Vector3(1f, 1f, 1f), 1f).setDelay(.6f).setEase(LeanTweenType.easeOutElastic).setOnComplete(othersAnimation);
    }
    void othersAnimation()
    {
        LeanTween.scale(_coins, new Vector3(1f, 1f, 1f), 1f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(_homeButton, new Vector3(1f, 1f, 1f), 1f).setDelay(.4f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(_nextLevelButton, new Vector3(1f, 1f, 1f), 1f).setDelay(.6f).setEase(LeanTweenType.easeOutElastic);
    }

    public void pressHomeButton()
    {

        PlayerPrefs.SetFloat("CoinAmount", CoinCounter.count + MoneyManager._amount);
        PlayerPrefs.Save();
        SwitchToLevel.SwitchToSceneByIndex(0);
    }

    public void pressNextButton()
    {

    }

}
