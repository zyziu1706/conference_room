using UnityEngine;
using System.Collections;

public class TVAnimations : MonoBehaviour {


	// Update is called once per frame
		void Update () {
		if ( Input.GetKey(KeyCode.Alpha1)){
				Debug.Log("Click");
			GetComponent<Animation>().Play ("TV_FadeIN");
				
		}else if (Input.GetKey(KeyCode.Alpha2)){
				GetComponent<Animation>().Play ("TV_FadeOUT");
				
			}
			
		}
		
}
