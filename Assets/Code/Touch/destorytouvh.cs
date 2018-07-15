using UnityEngine;
using System.Collections;

public class destorytouvh : MonoBehaviour 
{
	Ray ray;
	RaycastHit hit;
	
	void Update () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) // when you touch at the start
		{	
			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); // creating a ray 
			Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);// visiually see where the ray is going
			if (Physics.Raycast (ray,out hit,Mathf.Infinity))  // this when oject is hit something
			{
				Destroy (hit.transform.gameObject);
				Debug.Log ("Hit something"); // if it hits shows on concolue
			}

			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) // when you touch at the start
			{	
				ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); // creating a ray 
				Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);// visiually see where the ray is going
				if (Physics.Raycast (ray,out hit,0f))  // this when oject is hit something
				{
					Destroy (hit.transform.gameObject);
					Debug.Log ("Hit something"); // if it hits shows on concolue
				}

				if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) // when you touch at the start
				{	
					ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); // creating a ray 
					Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);// visiually see where the ray is going
					if (Physics.Raycast (ray,out hit,0f))  // this when oject is hit something
					{
						Destroy (hit.transform.gameObject);
						Debug.Log ("Hit something"); // if it hits shows on concolue
					}
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) // when you touch at the start
					{	
						ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); // creating a ray 
						Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);// visiually see where the ray is going
						if (Physics.Raycast (ray,out hit,0f))  // this when oject is hit something
						{
							Destroy (hit.transform.gameObject);
							Debug.Log ("Hit something"); // if it hits shows on concolue
						}
		
						if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Canceled) // when you touch at the start
						{	
							ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position); // creating a ray 
							Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);// visiually see where the ray is going
							if (Physics.Raycast (ray,out hit,0f))  // this when oject is hit something
							{
								Destroy (hit.transform.gameObject);
								Debug.Log ("Hit something"); // if it hits shows on concolue
							}
		}
		
	}
}
			}

		}

	}

}