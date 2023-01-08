using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnimationManager : MonoBehaviour
{

    Animator anim;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
	  player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
	  bool isRun = Input.GetKey("left shift");
        anim.SetFloat("speed", Input.GetAxis("Vertical"));
	  anim.SetFloat("Turn", Input.GetAxis("Mouse X"));
	  if((Input.GetAxis("Vertical")!=0)&& isRun){
		anim.SetBool("isRunning", true);
	  }if((Input.GetAxis("Vertical")!=0)&& !isRun){
		anim.SetBool("isRunning", false);
	  }
	  if(Input.GetKey(KeyCode.Space)){
		anim.SetBool("isJumping", true);
	  }if(!Input.GetKey(KeyCode.Space)){
		anim.SetBool("isJumping", false);
	  }
	  if(Input.GetKey(KeyCode.Q)){
		anim.SetBool("EnterKey", true);
	  }if(!Input.GetKey(KeyCode.Q)){
		anim.SetBool("EnterKey", false);
	  }
    }
}
