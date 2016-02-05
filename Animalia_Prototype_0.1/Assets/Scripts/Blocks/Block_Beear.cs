using UnityEngine;
using System.Collections;

public class Block_Beear : MonoBehaviour
{
    public Rigidbody Characters;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Char_Beear")
        {
            Destroy(gameObject);
        }
        if (other.name == "Char_Whagon")
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name != "Char_Beear")
        {
            Characters.AddForce(0f, 0f, 5f, ForceMode.Impulse);
        }
    }
}

