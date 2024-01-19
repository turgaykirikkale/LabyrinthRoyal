using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LoadAssetManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TMP_Text _coinAmount;
    [SerializeField] TMP_Text _healthAmount;
    [SerializeField] TMP_Text _timeCount;
    [SerializeField] TMP_Text _locationCount;


    public static bool _isAmountChange = false;
    public static bool _isHealthChange = false;
    public static bool _isTimeChange = false;
    public static bool _isLocationChange = false;
    void Start()
    {
        UpdateCoinAmount();
        UpdateHealthAmount();
        UpdateTimeAmount();
        UpdateLocationAmount();
    }

    void Update()
    {
        if (_isAmountChange)
        {
            UpdateCoinAmount();
        }
        if (_isHealthChange)
        {
            UpdateHealthAmount();
        }
        if (_isTimeChange)
        {
            UpdateTimeAmount();
        }
        if (_isLocationChange)
        {
            UpdateLocationAmount();
        }
    }



    void UpdateCoinAmount()
    {
        _coinAmount.text = MoneyManager._amount.ToString();
        _isAmountChange = false;
    }
    void UpdateHealthAmount()
    {
        _healthAmount.text = HealthCountManager._amount.ToString();
        _isHealthChange = false;
    }

    void UpdateTimeAmount()
    {
        _timeCount.text = TimeCountManager._amount.ToString();
        _isTimeChange = false;
    }

    void UpdateLocationAmount()
    {
        _locationCount.text = LocationCountManager._amount.ToString();
        _isLocationChange = false;

    }


}
