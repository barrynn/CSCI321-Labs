using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
//allows the platform to fall
    public bool fall = false;

    // Update is called once per frame
    void Update(){
        if(fall==true){
		gameObject.GetComponent<Rigidbody>().isKinematic = false;
		fall = false;
	  }
     }

}
