using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public Transform canvas;
	Ray rays;
	RaycastHit hits;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 	 // SETS UP TOUCH
		{
			rays = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);		 // creating a ray 
			Debug.DrawRay (rays.origin, rays.direction * 20, Color.red);			// visiually see where the ray is going

			if (Physics.Raycast (rays,out hits,Mathf.Infinity))  					// IF RAY HITS PAUSE BUTTON
			{
				Pauses();
				Debug.Log ("Pause"); 												//START PAUSE CLASS
			}
		}
	}
	public void Pauses()
	{
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0; // makes world pause 
		}
		else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}
}
