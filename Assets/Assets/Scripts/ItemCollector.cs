using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Include the name space for TextMesh Pro
using TMPro;
 

using UnityEngine.UI;//allows us to access text

public class ItemCollector : MonoBehaviour
{
      [SerializeField] AudioSource GetCoin;
   // [SerializeField] Text coinsText;
    [SerializeField]  TMP_Text m_TextComponent;
   int coins=0;//create insdie class so it resets each time level restarts

   private void  OnTriggerEnter(Collider other){
    if(other.gameObject.CompareTag("Coin")){
GetCoin.Play();
        Destroy(other.gameObject);
        coins++;
     m_TextComponent.text="Coins: "+coins;
    }
   }
}
