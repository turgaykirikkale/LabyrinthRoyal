using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCountManager : MonoBehaviour
{
    public static int _amount;
    private void Awake()
    {
        UpdateTimeAmount();
    }

    private void UpdateTimeAmount()
    {
        if (PlayerPrefs.HasKey("TimeAmount"))
        {
            _amount = PlayerPrefs.GetInt("TimeAmount");
        }
        else
        {
            _amount = 0;
        }
    }

    public static void IncreaseAmount(int value)
    {
        _amount += value;
        PlayerPrefs.SetInt("TimeAmount", _amount);
        PlayerPrefs.Save();
    }
    public static void DecreaseAmount(int value)
    {
        if (_amount > 0)
        {
            _amount -= value;
            PlayerPrefs.SetInt("TimeAmount", _amount);
            PlayerPrefs.Save();
        }

    }
}
