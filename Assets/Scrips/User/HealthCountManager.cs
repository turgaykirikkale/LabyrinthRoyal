using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCountManager : MonoBehaviour
{
    public static int _amount;

    private void Awake()
    {
        UpdateHealthAmount();
    }

    private void UpdateHealthAmount()
    {
        if (PlayerPrefs.HasKey("HealthAmount"))
        {
            _amount = PlayerPrefs.GetInt("HealthAmount");
        }
        else
        {
            _amount = 0;
        }
    }

    public static void IncreaseAmount(int value)
    {
        _amount += value;
        PlayerPrefs.SetInt("HealthAmount", _amount);
        PlayerPrefs.Save();
    }
    public static void DecreaseAmount(int value)
    {
        if (_amount > 0)
        {
            _amount -= value;
            PlayerPrefs.SetInt("HealthAmount", _amount);
            PlayerPrefs.Save();
        }

    }
}
