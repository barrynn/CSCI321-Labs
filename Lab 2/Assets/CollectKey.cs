using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public PlayerController player;
    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		player.hasKey = true;
		Destroy(gameObject);
		print("Key collected!");
	}
    }
}
