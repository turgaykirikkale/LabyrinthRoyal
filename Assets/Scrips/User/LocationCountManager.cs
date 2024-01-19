using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationCountManager : MonoBehaviour
{
    public static int _amount;
    private void Awake()
    {
        UpdateLocationAmount();
    }

    private void UpdateLocationAmount()
    {
        if (PlayerPrefs.HasKey("LocationAmount"))
        {
            _amount = PlayerPrefs.GetInt("LocationAmount");
        }
        else
        {
            _amount = 0;
        }
    }
    public static void IncreaseAmount(int value)
    {
        _amount += value;
        PlayerPrefs.SetInt("LocationAmount", _amount);
        PlayerPrefs.Save();
    }
    public static void DecreaseAmount(int value)
    {
        if (_amount > 0)
        {
            _amount -= value;
            PlayerPrefs.SetInt("LocationAmount", _amount);
            PlayerPrefs.Save();
        }
    }
}
