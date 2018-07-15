using UnityEngine;
using System.Collections;

public class destroycollide : MonoBehaviour {

void OnCollisionEnter (Collision col) 
	{ 

		if(col.gameObject.name == "Icicles(Clone)")
		{
			Destroy(col.gameObject);
		}

		
}
}