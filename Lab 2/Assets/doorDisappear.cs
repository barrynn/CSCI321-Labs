using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorDisappear : MonoBehaviour
{
    public PlayerController player;
    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		if(player.hasKey==true){
			print("Key detected.");
			Destroy(GameObject.Find("destroy door"));
		}else{
			print("No key detected. Find key to continue.");
		}
	}
    }
}
