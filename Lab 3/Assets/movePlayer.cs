using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
//once the player character enters the trigger, the player is made the child of the
//moving platform and moves with the platform
    public PlatformMove mPlat;
    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		col.transform.parent = mPlat.transform;
	}
    }
//Once the player character leaves the trigger it removes the player as a child
//and the player no longer moves with the platform
    void OnTriggerExit(Collider col){
	if(col.CompareTag("Player")){
		col.transform.parent = null;
	}
    } 
}
