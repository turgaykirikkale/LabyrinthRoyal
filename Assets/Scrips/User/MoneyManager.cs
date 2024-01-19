using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{

    public static float _amount;


    private void Awake()
    {
        UpdateCoinAmount();
    }
    void UpdateCoinAmount()
    {
        if (PlayerPrefs.HasKey("CoinAmount"))
        {
            // Kayıtlı bir miktar varsa, onu yükle
            _amount = PlayerPrefs.GetFloat("CoinAmount");
        }
        else
        {
            _amount = 0f;
        }

    }
    public static void IncreaseAmount(float value)
    {

        _amount += value;
        PlayerPrefs.SetFloat("CoinAmount", _amount);
        PlayerPrefs.Save();
    }
    public static void DecreaseAmount(float value)
    {
        if (_amount > 0)
        {
            _amount -= value;
            PlayerPrefs.SetFloat("CoinAmount", _amount);
            PlayerPrefs.Save();
        }

    }


}
