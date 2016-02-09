using UnityEngine;
using System.Collections;

public class Move_Whagon : MonoBehaviour
{
    public Rigidbody Whagon;

    void Start ()
    {
        Whagon = GetComponent<Rigidbody>();
        Whagon.AddForce(0f, 0f, 15f, ForceMode.Impulse);
    }
	
	void FixedUpdate ()
    {
    
    }
}
