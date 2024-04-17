using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        CollectableControl.coinCount += 1;
        coinFX.Play();
        this.gameObject.SetActive(false);
    }
}


