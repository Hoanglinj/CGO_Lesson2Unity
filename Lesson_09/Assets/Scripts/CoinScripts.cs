using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int coinValue = 100;
    private void OnTriggerEnter(Collider other)
    {
        MenuScripts.instance.coins += coinValue;
        MenuScripts.instance.CoinText.text = MenuScripts.instance.coins.ToString();
        Destroy(this.gameObject);
        
    }
}
