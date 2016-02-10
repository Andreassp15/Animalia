using UnityEngine;
using System.Collections;

public class Block_Pit : MonoBehaviour
{
    public Rigidbody Characters;

    void OnTriggerEnter(Collider other)
    {
        if (other.name != "Char_Beear")
        {
            Characters.constraints &= ~RigidbodyConstraints.FreezePositionY;
            Characters.AddForce(0f, -100f, 0f, ForceMode.Impulse);
        }
    }
}
