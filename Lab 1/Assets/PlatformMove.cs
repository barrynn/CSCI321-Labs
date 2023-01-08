using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField]
    Transform pos1;
    [SerializeField]
    Transform pos2;
    float speed = 3f;
    bool moveRight = true;
//moves the platform between two predetermined points
    void FixedUpdate(){
	if (gameObject.transform.position == pos2.position){
		moveRight = true;
	}else if (gameObject.transform.position == pos1.position){
		moveRight = false;
	}
	if(moveRight == true){
		gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pos1.position, speed * Time.deltaTime); 
	}else{
		gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pos2.position, speed * Time.deltaTime); 
	}
    }


}