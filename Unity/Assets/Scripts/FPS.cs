﻿


	using UnityEngine;
	using System.Collections;
	
	/// MouseLook rotates the transform based on the mouse delta.
	/// Minimum and Maximum values can be used to constrain the possible rotation
	
	/// To make an FPS style character:
	/// - Create a capsule.
	/// - Add the MouseLook script to the capsule.
	///   -> Set the mouse look to use LookX. (You want to only turn character but not tilt it)
	/// - Add FPSInputController script to the capsule
	///   -> A CharacterMotor and a CharacterController component will be automatically added.
	
	/// - Create a camera. Make the camera a child of the capsule. Reset it's transform.
	/// - Add a MouseLook script to the camera.
	///   -> Set the mouse look to use LookY. (You want the camera to tilt up and down like a head. The character already turns.)
	[AddComponentMenu("Camera-Control/Mouse Look")]
public class FPS : MonoBehaviour {
		
		//public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
		//public RotationAxes axes = RotationAxes.MouseXAndY;
		public float sensitivityX = 10F;
		public float sensitivityY = 10F;
		
		public float minimumX = -360F;
		public float maximumX = 360F;
		
		public float minimumY = -50F;
		public float maximumY = 50F;
		
		public int speed = 30;
		public bool canMove = true;
		float rotationY = 0F;
		
		void Update ()
		{
			//Check if moving is posiible
			if (canMove == true) {
				//Mouse camera rotation controll
				transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);

				/* TO MOŻE SIĘ PRZYDAĆ JAK BĘDZIEMY CHCIELI ROBIĆ SWOBODNY RUCH MYSZĄ
				if (axes == RotationAxes.MouseXAndY)
				{
					float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
					
					rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
					rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
					
					transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
				}
				else if (axes == RotationAxes.MouseX)
				{
					transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
				}
				else
				{
					rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
					rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
					
					transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
				}
				*/

				//Keyboard camera movement controll
				if (Input.GetKey (KeyCode.W)) {
						transform.position += transform.forward * speed * Time.deltaTime; 

				}
				if (Input.GetKey (KeyCode.S)) {
						transform.position += transform.forward * -speed * Time.deltaTime; 
		
				}
				if (Input.GetKey (KeyCode.A)) {
						transform.position += transform.right * -speed * Time.deltaTime; 
		
				}
				if (Input.GetKey (KeyCode.D)) {
						transform.position += transform.right * speed * Time.deltaTime; 
		
				}
			}

		}

	}