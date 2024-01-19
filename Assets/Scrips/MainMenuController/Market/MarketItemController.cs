using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MarketItemController : MonoBehaviour
{
    // Start is called before the first frame update
    float price;


    public void onPressItemMarket()
    {
        if (ControlMarketType._isAsset)
        {
            price = float.Parse(transform.GetChild(3).GetChild(1).GetComponent<TMP_Text>().text);

            if (price < MoneyManager._amount)
            {
                LoadAssetManager._isAmountChange = true;
                MoneyManager.DecreaseAmount(price);
                if (transform.CompareTag("MHealth"))
                {
                    LoadAssetManager._isHealthChange = true;
                    int count = int.Parse(transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text);
                    HealthCountManager.IncreaseAmount(count);
                }
                if (transform.CompareTag("MLocation"))
                {
                    Debug.Log("MLocation : " + transform.tag);
                    LoadAssetManager._isLocationChange = true;
                    int count = int.Parse(transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text);
                    LocationCountManager.IncreaseAmount(count);
                }
                if (transform.CompareTag("MTime"))
                {

                    LoadAssetManager._isTimeChange = true;
                    int count = int.Parse(transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text);
                    TimeCountManager.IncreaseAmount(count);
                }


            }
            else
            {
                Debug.Log("Bakiye Yeterseiz");


            }

        }
        else
        {
            price = float.Parse(transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text);
            LoadAssetManager._isAmountChange = true;
            MoneyManager.IncreaseAmount(price);

        }



    }
}
