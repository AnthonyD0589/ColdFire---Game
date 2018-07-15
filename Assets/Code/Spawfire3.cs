using UnityEngine;
using System.Collections;

public class Spawfire3 : MonoBehaviour {

	public bool iscreated = false; 
	public GameObject fire4;    // fire 1 is the biggest fire, fire 4 is the smallest fire
	
	void OnCollisionEnter (Collision col)
	{ 
		if (col.gameObject.name == "Icicles(Clone)") 
		{
			Destroy (col.gameObject);
			transform.position = new Vector3 (3.72f, 0.42f, -6.5f );
			iscreated = true;
			
			if (iscreated) 
			{
				Quaternion spawnRotation = Quaternion.identity;
				Vector3 spawnPosition = new Vector3 (
					-0.01899999f, 0.359955f, -6.427f);
				Instantiate (fire4, spawnPosition, spawnRotation);
				iscreated = false; 
				
			}
			
			
		}
	}
	
}


