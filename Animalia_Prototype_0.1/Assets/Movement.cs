using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public int forwardSpeed = 1;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Moves character forward
		transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
			
		//Moves character sideways
		{
			transform.position = new Vector3 (transform.position.x+1,transform.position.y,transform.position.z);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			transform.position = new Vector3 (transform.position.x-1,transform.position.y,transform.position.z);
		}
	}
	//void OnTriggerEnter(Collider other)
	//{
	//	if (other.tag == "Block")
	//		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 2);
	//}
}
