using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public static class ButtonExtension
{

    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

public class ControllScrollItems : MonoBehaviour
{
    [SerializeField] GameObject container;
    [SerializeField] GameObject prefabLevelButton;
    private int numberOfLevels = 50;
    private int currentLevel = 6; //PlayerPreftan alacagım.
    public static int inLevel;

    void Awake()
    {
        container.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, numberOfLevels * 400);
        Vector3 newPosition = container.transform.position;
        newPosition.x = 10200f;
        container.transform.position = newPosition;
        for (int i = 0; i < numberOfLevels; i++)
        {

            GameObject spawnedObject = Instantiate(prefabLevelButton, transform.position, Quaternion.identity);
            spawnedObject.transform.parent = transform;
            spawnedObject.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = (i + 1).ToString();

            if (i + 1 < currentLevel)
            {
               
                // spawnedObject.transform.GetChild(0).GetComponent<Button>().interactable = false;
                spawnedObject.transform.GetChild(1).gameObject.SetActive(true);
                spawnedObject.transform.GetChild(2).gameObject.SetActive(false);
            }
            else
            {
                spawnedObject.transform.GetChild(1).gameObject.SetActive(false);

            }
            spawnedObject.transform.GetChild(0).GetComponent<Button>().AddEventListener(i + 1, itemClicked);

        }
    }

    void itemClicked(int i)
    {
        inLevel = i; //in level +1 olacak güncellenen levele göre. eğer oyundan çıkarsa burayı tamamlamadan inlevelde kalacak.
        FinishManager._isFinish = false;
        GameDownCounter.timer = ControlLevelTime.controlTime(i);
        Health._currentHealth = 100;
        CoinCounter.count = 0f;
        TakingKey._isTakedKey = false;
        GameOver.isGameOver = false;
        Health.isGameOver = false;
        SwitchToLevel.SwitchToSceneByIndex(i);
    }
}
