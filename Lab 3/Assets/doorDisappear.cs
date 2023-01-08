using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorDisappear : MonoBehaviour
{

    public GameObject OpenPanel = null;
    public GameObject piv;
    Animator anim;
    public PlayerController player;

    void Start(){
	anim = piv.GetComponent<Animator>();
	OpenPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		if(player.hasKey == true){
			print("Key detected");
			OpenPanel.SetActive(true);
		}else{
			print("Key not detected.");
		}
	}
    }

    void OnTriggerExit(Collider col){
	if(col.CompareTag("Player")){
		OpenPanel.SetActive(false);
	}
    }

    private bool IsOpenPanelActive{
	get{
		return OpenPanel.activeInHierarchy;
	}
    }

    void Update(){
	if(IsOpenPanelActive){
		if(Input.GetKeyDown(KeyCode.Q)){
			OpenPanel.SetActive(false);
			anim.SetBool("openDoor", true);
		}
	}
    }

}
