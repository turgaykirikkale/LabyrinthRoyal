using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text _countUp;
    public static float count = 0;
    public static bool isCounting = false;


    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            count += 1;
            _countUp.text = count.ToString();
            isCounting = false;
        }
    }
}
