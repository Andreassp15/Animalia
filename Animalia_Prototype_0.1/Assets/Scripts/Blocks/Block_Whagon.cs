using UnityEngine;
using System.Collections;

public class Block_Whagon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Char_Whagon")
        {
            Destroy(gameObject);
        }
    }
}
