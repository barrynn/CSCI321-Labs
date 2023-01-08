using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When the player lands on the final platform it triggers the winning message
//also prints how long it took the player to complete the course
public class YouWin : MonoBehaviour
{
    float time;
    // Update is called once per frame
    void Update(){
        time +=Time.deltaTime;
    }
    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		int min = (int) Mathf.Floor(time/60);
		int sec = (int) time%60;
		print(string.Format("You completed the course in {0}:{1}!", min.ToString(), sec.ToString()));
      }
    }
}
