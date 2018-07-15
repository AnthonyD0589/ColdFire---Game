using UnityEngine;
using System.Collections;

public class destroyflame : MonoBehaviour 
{
	// destory Fire
	void OnCollisionEnter (Collision col) 
	{ 
		
		if(col.gameObject.name == "GameFire")
		{
			Destroy(col.gameObject);
			
		}
		
		
	}
}
