using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public int forwardSpeed = 1;
    public Rigidbody Characters;
    
    void Start()
    {
        Characters = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Moves character forward
     //   transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        //Moves character forward
        Characters.MovePosition(transform.position + transform.forward * forwardSpeed * Time.deltaTime);
        //Moves character sideways
        if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
		}
	}
    /*
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Block")
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 2);
	}
    */
}
