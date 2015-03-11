using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetInPrezi : MonoBehaviour {

	public Text pressToEnter;

	private bool getIn = false;

	void Awake(){
		pressToEnter.text = "";
	}

	void OnTriggerEnter(Collider obj){ 
		//if (obj.tag == "MainCammera") {
			getIn = true;
			pressToEnter.text = "Press E to enter Prezi Board";
			Debug.Log ("In"); 
		}
	
	void OnTriggerExit(Collider obj){  
			//if (obj.tag == "MainCammera") {
				getIn = false; 
				pressToEnter.text = "";
				Debug.Log ("Out");
			}
		

}
