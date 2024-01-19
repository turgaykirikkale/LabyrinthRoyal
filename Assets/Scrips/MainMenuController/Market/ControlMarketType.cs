using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMarketType : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _assetsPanel, _coinsPanel;
    [SerializeField] Button _assetButton, _coinButton;
    [SerializeField] GameObject _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14;
    [SerializeField] GameObject _c0, _c1, _c2, _c3, _c4, _c5, _c6;
    public static bool _isAsset = true;
    void Start()
    {
        _coinsPanel.SetActive(false);
        _assetButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (_isAsset)
        {
            _coinsPanel.SetActive(false);
            _assetsPanel.SetActive(true);
            _assetButton.interactable = false;
            _coinButton.interactable = true;
        }
        else
        {
            _coinsPanel.SetActive(true);
            _assetsPanel.SetActive(false);
            _assetButton.interactable = true;
            _coinButton.interactable = false;
        }
    }

    public void setMarketTypeAssets()
    {
        _assetsPanel.SetActive(true);
        _coinsPanel.SetActive(false);
        _isAsset = true;
        _assetButton.interactable = false;
        _coinButton.interactable = true;
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
        LeanTween.scale(_c0, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c1, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c2, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c3, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c4, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c5, new Vector3(0f, 0f, 0f), 0.01f);
        LeanTween.scale(_c6, new Vector3(0f, 0f, 0f), 0.01f);
    }

    public void setMarketTypeCoins()
    {
        _coinsPanel.SetActive(true);
        _assetsPanel.SetActive(false);
        _isAsset = false;
        _coinButton.interactable = false;
        _assetButton.interactable = true;

        LeanTween.scale(_c0, new Vector3(1f, 1f, 1f), 0.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c1, new Vector3(1f, 1f, 1f), 0.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c2, new Vector3(1f, 1f, 1f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c3, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c4, new Vector3(1f, 1f, 1f), 0.9f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c5, new Vector3(1f, 1f, 1f), 1.1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(_c6, new Vector3(1f, 1f, 1f), 1.3f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
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
    }

}
