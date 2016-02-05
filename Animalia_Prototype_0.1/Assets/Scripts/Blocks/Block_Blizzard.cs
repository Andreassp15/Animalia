using UnityEngine;
using System.Collections;

public class Block_Blizzard : MonoBehaviour
{
    public Rigidbody Characters;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Char_Blizzard")
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
        if (other.name != "Char_Blizzard")
        {
            Characters.AddForce(0f, 0f, 5f, ForceMode.Impulse);
        }
    }
}

