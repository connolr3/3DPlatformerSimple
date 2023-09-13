/*This script manaages death. Any enemy who causes death should be tagged with "EnemyBody". Also causes death is the 
gameobject the script is applied to falls below -9 in the y axis (should be the player).*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;//used for relaoding level
using UnityEngine.UI;//allows us to access image


public class Death : MonoBehaviour
{
   [SerializeField] AudioSource DeathNoise;
      [SerializeField] RawImage GameOverImage;
   bool dead = false;
   void Start(){
      GameOverImage.enabled=false;
   }
   void Update(){
      if(transform.position.y<=-9f && !dead){
         Die();
      }
   }
   
   private  void OnCollisionEnter(Collision collision){
   if(collision.gameObject.CompareTag("EnemyBody")){
      GetComponent<MeshRenderer>().enabled=false;//make invisible
     GetComponent<Rigidbody>().isKinematic=true;//stops it being pushed by other objects
     GetComponent<PlayerMovement>().enabled=false;//stop moving
      Die();
   }
   }

 void Die(){
     GameOverImage.enabled=true;
   DeathNoise.Play();
     Invoke(nameof(ReloadLevel),1.3f);//delay after 1.3 seconds
     dead=true;
  
 }


 void ReloadLevel(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);//reload the currently active scene
 }


}
