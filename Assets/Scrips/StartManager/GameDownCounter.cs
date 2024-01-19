using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDownCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text _countUp;
    public static bool _gameCounting = false;
    public static float timer = 0; //Buraya Level Timer alacak
    // Update is called once per frame
    void Update()
    {
        if (_gameCounting)
        {

            timer -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            if (seconds < 0)
            {
                GameOver.isGameOver = true;
                _gameCounting = false;
            }
            else
            {
                _countUp.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }

        }
    }
}
