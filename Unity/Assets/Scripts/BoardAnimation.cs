using UnityEngine;
using System.Collections;

public class BoardAnimation : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.W)){
			Debug.Log("Click");
			animation.Play ("Board_FadeIN");

		}else if (Input.GetKey(KeyCode.S)){
			animation.Play ("Board_FadeOUT");

		}
	
	}
}
