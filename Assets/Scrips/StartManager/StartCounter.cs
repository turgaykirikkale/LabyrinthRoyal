using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class StartCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text _countDown;
    public static bool isCounting = true;
    //float timer = GameOverScript.isComingGameOver ? 4 : 3;
    float timer = 4f;
    [SerializeField] GameObject enterenceDoor;

    // Update is called once per frame
    void Update()
    {

        if (isCounting)
        {
            if (timer > 1)
            {
                if (timer < 4)
                {
                    int seconds = Mathf.FloorToInt(timer % 60);
                    _countDown.text = seconds.ToString();

                }
                timer -= Time.deltaTime;
            }
            else
            {
                isCounting = false;
                _countDown.enabled = false;
                LeanTween.moveLocal(enterenceDoor, new Vector3(1.800911f, 1.01f, -2.011781f), 0.8f).setEase(LeanTweenType.easeOutCubic).setOnComplete(startGameCounter);
            }

        }

        //int minutes = Mathf.FloorToInt(timer / 60);


    }

    void startGameCounter()
    {
        GameDownCounter._gameCounting = true;
    }
}
