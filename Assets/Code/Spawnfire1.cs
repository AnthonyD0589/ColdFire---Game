using UnityEngine;
using System.Collections;

public class Spawnfire1 : MonoBehaviour {																	// FIRE 1 - FIRE 5 BIGGEST TO SMALLEST
	
	public float timer = 0.0f;
	public float timerlimit = 2.0f;
	public float instantiatefire2 = 0.0f;
	
	public bool iscreated = true; 
	public bool timerstart = false;
	
	public GameObject fire2;   																					

	void OnCollisionEnter (Collision col) //sets collision
	{ 
		if (col.gameObject.name == "Icicles(Clone)") 														//IF FIRE COLLIDES WITH ICICLES
		{     																								
			Destroy (col.gameObject);    																	// DESTROY ICICLES
			transform.position = new Vector3 (-3f, -0.25f, -6.5f); 											// MOVE FIRE1 OUT
			

			Vector3 movefire2in = new Vector3 (0f, 0.42f, -6.5f);
			fire2.transform.position = movefire2in;					 										//MOVE FIRE2 IN
									
			iscreated = false; 
				
			if (!iscreated) 																				//IF FIRE1 COLLIDES START TIMER
			{
					
				timerstart = true;
			}

		}
	}


	void Update()
	{
		if (timerstart) 			
		{
			timer += Time.deltaTime; 																		//SETS UP THE TIMER
		}
		
		if (timer > timerlimit) 

		{																									// IF TIMER REACHES TIMERLIMIT {

			timer = 0.0f;
			timerstart = false;
			
			Debug.Log ("Reached!");

			transform.position = new Vector3 (-0.15f, -0.277f, -6.5f); 											// MOVES FIRE 1 BACK INTO GAME

			Vector3 movefire2out = new Vector3 (3f, 0.42f, -6.5f); 											// MOVES FIRE2 CLONE OUT OF THE GAME
			fire2.transform.position = movefire2out;

		}

		if (fire2.transform.position == new Vector3 (-3f, 0.42f, -6.5f)) 									//IF FIRE2 MOVES OUT STOP THE TIMER
		{

			timer = 0.0f;
			timerstart = false;

		}

		if (fire2.transform.position == new Vector3 (0f, 0.42f, -6.5f)) 									//IF FIRE 2 MOVES IN START THE TIMER
		{

			timerstart = true;
			
		}



				
}
}




















