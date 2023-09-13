using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script to make player a child when it touches
public class StickyPlatform : MonoBehaviour
{

    //parent player from moving platform
private  void OnCollisionEnter(Collision collision){
if(collision.gameObject.name=="Player"){
    collision.gameObject.transform.SetParent(transform);
}
 }

//unparent player from moving platform
 private  void OnCollisionExit(Collision collision){
if(collision.gameObject.name=="Player"){
    collision.gameObject.transform.SetParent(null);
}
 }



}
