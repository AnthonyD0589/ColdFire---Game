using UnityEngine;
using System.Collections;

public class SpawnIce : MonoBehaviour {

	public Rigidbody rb;
	public Camera cam;
	public GameObject ball;
	private float maxWidth;
	public float waittime;

    float waittimefinal;
	public float timer = 0.0f;
	public float timer2 = 0.0f;
	public float timer3 = 0.0f;
	public float timer4 = 0.0f;

	public bool isCoroutineStarted = false;
	public bool isCoroutineStarted2 = false;
	public bool isCoroutineStarted3 = false;
	public bool isCoroutineStarted4 = false;
	
	public bool IncreaseTimer = true;
	public bool IncreaseTimer2 = true;
	public bool IncreaseTimer3 = true;
	public bool IncreaseTimer4 = true;

	void Update()
	{
		if (IncreaseTimer == true) {

			timer += Time.deltaTime; //sets timer in realtime

		}

		if (IncreaseTimer2 == true) {

			if (IncreaseTimer == false) {

				timer2 += Time.deltaTime;
			}
		}

		if (IncreaseTimer3 == true) {
			
			if (IncreaseTimer2 == false) {
				
				timer3 += Time.deltaTime;
			}
		}

		if (IncreaseTimer4 == true) {
			
			if (IncreaseTimer3 == false) {
				
				timer4 += Time.deltaTime;
			}
		}

		waittime = Random.Range (20f, 30f); //sets waittime to random values between 15 and 20

		if (!isCoroutineStarted) { //isCorot
				
			StartCoroutine ("Spawn"); //starts the Spawn
		}

		if (timer > waittime) {    
			timer = 0.0f;
			StopCoroutine ("Spawn");
			isCoroutineStarted2 = true;
			IncreaseTimer = false;

		} 

		if (timer2 > waittime) {
			timer2 = 0.0f;
			StopCoroutine ("Spawn2");
			isCoroutineStarted3 = true;
			IncreaseTimer2 = false;


		}	

		if (timer3 > waittime) {
			timer3 = 0.0f;
			StopCoroutine ("Spawn3");
			isCoroutineStarted4 = true;
			IncreaseTimer3 = false;

			
		}	

		if (timer4 > waittime) {
			IncreaseTimer4 = false;

			
		}	



		if (isCoroutineStarted2) {

			StartCoroutine ("Spawn2");
		}
	

		if (isCoroutineStarted3) {
		
			StartCoroutine ("Spawn3");
		}

		if (isCoroutineStarted4) {
	
			StartCoroutine ("Spawn4");
		}
	}


IEnumerator Spawn()
	{
		isCoroutineStarted = true;
		yield return new WaitForSeconds (1);	
		while (true) 
		{	
			Vector3 spawnPosition = new Vector3 (
				Random.Range (-1.5f, 1.5f), 
				transform.position.y,
				-6.5f
				);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (ball, spawnPosition, spawnRotation);
			Vector3 scale = ball.transform.localScale;
			scale.x = Random.Range (0.35f, 0.55f);
			ball.transform.localScale = scale;
			yield return new WaitForSeconds(Random.Range(1,2f));
			
		}
	}

	IEnumerator Spawn2()
	{
		isCoroutineStarted2 = false;
		yield return new WaitForSeconds (0);	
		while (true) 
		{	
			Vector3 spawnPosition = new Vector3 (
				Random.Range (-1.5f, 1.5f), 
				transform.position.y,
				-6.5f
				);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (ball, spawnPosition, spawnRotation);
			Vector3 scale = ball.transform.localScale;
			scale.x = Random.Range (0.35f, 0.55f);
			ball.transform.localScale = scale;
			yield return new WaitForSeconds(Random.Range(0.4f,0.5f));
			
		}
	}
	IEnumerator Spawn3()
{
	isCoroutineStarted3 = false;
	yield return new WaitForSeconds (0);	
	while (true) 
	{	
		Vector3 spawnPosition = new Vector3 (
			Random.Range (-1.5f, 1.5f), 
			transform.position.y,
			-6.5f
			);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (ball, spawnPosition, spawnRotation);
		Vector3 scale = ball.transform.localScale;
		scale.x = Random.Range (0.35f, 0.55f);
		ball.transform.localScale = scale;
		yield return new WaitForSeconds(Random.Range(0.3f,0.4f));
		
	}
}

	IEnumerator Spawn4()
{	
	isCoroutineStarted4 = false;
	yield return new WaitForSeconds (0);	
	while (true) 
	{	
		Vector3 spawnPosition = new Vector3 (
			Random.Range (-1.5f, 1.5f), 
			transform.position.y,
			-6.5f
			);
		
		Quaternion spawnRotation = Quaternion.identity;
		GameObject thisball = Instantiate (ball, spawnPosition, spawnRotation) as GameObject;
		Vector3 scale = ball.transform.localScale;
		scale.x = Random.Range (0.35f, 0.55f);
		ball.transform.localScale = scale;
		yield return new WaitForSeconds(Random.Range(0.2f,0.3f));
		
	}
}



}



