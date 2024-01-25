using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSettingButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _panel, _menuBackground, _closeButton, _audioButton, _notificationButton, _shareButton, _helpButton, _rateUsButton;

    public void PressButton()
    {
        _panel.SetActive(true);
        LeanTween.scale(_panel, new Vector3(1f, 1f, 1f), 0.7f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(scaleBackgroundUp);

    }
    void scaleBackgroundUp()
    {
        LeanTween.scale(_menuBackground, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutBounce).setOnComplete(moveBackgroundUp);

    }
    void moveBackgroundUp()
    {
        LeanTween.moveLocal(_menuBackground, new Vector2(0f, 0f), 0.4f).setDelay(0.4f).setEase(LeanTweenType.easeOutCubic).setOnComplete(scaleButtons);
    }
    void scaleButtons()
    {
        LeanTween.scale(_closeButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_audioButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.2f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_notificationButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.3f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_shareButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.4f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_helpButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.5f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_rateUsButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.6f).setEase(LeanTweenType.easeOutBounce);
    }
    public void closeSettingPanel()
    {
        _panel.SetActive(false);
        LeanTween.scale(_panel, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_menuBackground, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.moveLocal(_menuBackground, new Vector2(0f, -1300f), 0.001f);
        LeanTween.scale(_closeButton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_audioButton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_notificationButton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_shareButton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_helpButton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_rateUsButton, new Vector3(0f, 0f, 0f), 0.001f);

    }

}
