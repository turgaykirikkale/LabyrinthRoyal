using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _coin;
    [SerializeField] Transform _shakingObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CoinCounter.isCounting = true;
            Destroy(_coin);

        }
    }
}
