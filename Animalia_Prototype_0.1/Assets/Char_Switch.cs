using UnityEngine;
using System.Collections;

public class Char_Switch : MonoBehaviour {
	
	public int currentChar;
	public Transform[] Characters;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			changeCharacter (0);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			changeCharacter (1);
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			changeCharacter (2);
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) 
		{
			changeCharacter (3);
		}
	}
	public void changeCharacter(int num)
	{
		currentChar = num;
		for(int i = 0; i < Characters.Length; i++)
		{
			if(i == num)
				Characters[i].gameObject.SetActive(true);
			else
				Characters[i].gameObject.SetActive(false);
		}
	}
}
