using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Rigidbody Characters;
    bool moveLeft;
    bool moveRight;

    void Start()
    {
        Characters = GetComponent<Rigidbody>();
        Characters.AddForce(0f, 0f, 15f, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        //Moves character forward
        Characters.AddForce(0f, 0f, 100f * Time.deltaTime, ForceMode.Acceleration);

        //Moves character sideways
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (moveRight == false)
            {
                transform.Translate(Vector3.right*3);
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (moveLeft == false)
            {
                transform.Translate(Vector3.left*3);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Collider_Edge2")
        {
            moveLeft = true;
        }
        if (other.transform.name == "Collider_Edge1")
        {
            moveRight = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Collider_Edge2")
        {
            moveLeft = false;
        }
        if (other.transform.name == "Collider_Edge1")
        {
            moveRight = false;
        }
    }
}

