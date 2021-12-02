using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{

    private float coinNum = 0f;
    public Text coinText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Carrot")
        {
            coinNum++;
            coinText.text = coinNum.ToString();
            Destroy(other.gameObject);
        }
    }

}
