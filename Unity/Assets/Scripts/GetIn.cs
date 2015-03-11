using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetIn : MonoBehaviour {

	public Text pressToEnter;

	private bool getIn = false;
	private string name;

	void Awake(){
		pressToEnter.text = "";
	}

	void Update(){
		if (getIn == true && Input.GetKey(KeyCode.E)){
			Camera.main.transform.position = new Vector3(-12, 11, 0);
           
			//TODO
			//Trzeba ustawić canMove na false w skrypcie FPS.cs żeby zablokować poruszanie
		}
	}

	void OnTriggerEnter(Collider obj){ 
		if (obj.tag == "MainCamera") {
			getIn = true;

			switch (tag)
			{
			case "UserScreenTrigger":
				name = "User Screen";
				break;
			case "WhiteBoardTrigger":
				name = "Whiteboard";
				break;
			case "PreziBoardTrigger":
				name = "Prezi Board";
				break;
			}

			pressToEnter.text = "Press E to enter " + name;
		}
	}
	void OnTriggerExit(Collider obj){  
			if (obj.tag == "MainCamera") {
				getIn = false; 
				pressToEnter.text = "";
			}
	}

}
