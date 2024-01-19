using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _panel, _menuBackground, _assetsBotton, _coinsButton, _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14;
    [SerializeField] GameObject _c0, _c1, _c2, _c3, _c4, _c5, _c6;
    // Update is called once per frame
    public void onPressMarketButton()
    {
        //  LeanTween.moveLocal(_backPanel, new Vector3(0f, 0f, 0f), 0.5f).setDelay(0.3f).setEase(LeanTweenType.easeOutCirc).setOnComplete(starsAnim);
        _panel.SetActive(true);
        LeanTween.scale(_panel, new Vector3(1f, 1f, 1f), 0.7f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(scaleBackgroundUp);
    }

    public void onPressGoldButton()
    {
        _panel.SetActive(true);
        ControlMarketType._isAsset = false;
        LeanTween.scale(_panel, new Vector3(1f, 1f, 1f), 0.7f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(scaleBackgroundUp);
    }
    void scaleBackgroundUp()
    {
        LeanTween.scale(_menuBackground, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutBounce).setOnComplete(moveBackgroundUp);

    }
    void moveBackgroundUp()
    {
        LeanTween.moveLocal(_menuBackground, new Vector2(0f, 0f), 0.4f).setDelay(0.4f).setEase(LeanTweenType.easeOutCubic).setOnComplete(arrengeButton);
    }

    void arrengeButton()
    {
        LeanTween.scale(_assetsBotton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale(_coinsButton, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.2f).setEase(LeanTweenType.easeOutBounce).setOnComplete(ArrangeItems);
    }
    void ArrangeItems()
    {
        if (ControlMarketType._isAsset)
        {
            LeanTween.scale(_0, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_1, new Vector3(1f, 1f, 1f), 0.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_2, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_3, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_4, new Vector3(1f, 1f, 1f), 0.9f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_5, new Vector3(1f, 1f, 1f), 1.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_6, new Vector3(1f, 1f, 1f), 1.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_7, new Vector3(1f, 1f, 1f), 1.5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_8, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_9, new Vector3(1f, 1f, 1f), 0.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_10, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_11, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_12, new Vector3(1f, 1f, 1f), 0.9f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_13, new Vector3(1f, 1f, 1f), 1.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_14, new Vector3(1f, 1f, 1f), 1.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        }
        else
        {
            LeanTween.scale(_c0, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c1, new Vector3(1f, 1f, 1f), 0.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c2, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c3, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c4, new Vector3(1f, 1f, 1f), 0.9f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c5, new Vector3(1f, 1f, 1f), 1.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.scale(_c6, new Vector3(1f, 1f, 1f), 1.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        }

    }
    void ScaleToZeroItems()
    {
        LeanTween.scale(_0, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_1, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_2, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_3, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_4, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_5, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_6, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_7, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_8, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_9, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_10, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_11, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_12, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_13, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_14, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c0, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c1, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c2, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c3, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c4, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c5, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c6, new Vector3(0f, 0f, 0f), 0.01f);
    }



    public void closeMarket()
    {
        _panel.SetActive(false);
        LeanTween.scale(_panel, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_menuBackground, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_assetsBotton, new Vector3(0f, 0f, 0f), 0.001f);
        LeanTween.scale(_coinsButton, new Vector3(0f, 0f, 0f), 0.001f);
        ScaleToZeroItems();
        LeanTween.moveLocal(_menuBackground, new Vector2(0f, -1500f), 0.001f);
        ControlMarketType._isAsset = true;
    }
}
