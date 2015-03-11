using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
    [SerializeField] private GameObject button;
    private string sceneName;
	// Use this for initialization
	void Start () {
        sceneName = gameObject.name.ToString();

	
	}
	
	// Update is called once per frame
	void Update () {
         if(Input.GetMouseButton(0))
             Application.LoadLevel(sceneName);
     }
	
	
}
