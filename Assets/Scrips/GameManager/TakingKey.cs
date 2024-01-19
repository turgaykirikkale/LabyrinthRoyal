using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingKey : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _key;
    public static bool _isTakedKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isTakedKey = true;
            Destroy(_key);
        }
    }
}
