using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallTrigger : MonoBehaviour
{
//triggers the falling platforms to fall. After .3 seconds the platform begins it's 
//descent and 2 seconds after that it is returned to its starting position
    public PlatformFall plat;
    IEnumerator OnTriggerEnter(Collider coll){
	if(coll.CompareTag("Player")){
		Vector3 pos = plat.gameObject.transform.position;
		yield return new WaitForSeconds(.3f);
		plat.fall = true;
		yield return new WaitForSeconds(2);
		plat.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		plat.gameObject.transform.position = pos;
	}
    }
}
