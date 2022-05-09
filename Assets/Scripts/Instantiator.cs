using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
	public GameObject objectToClone;

	public void CloneObject()
	{
		int cont = 0;
		while (cont<3)
		{
			Instantiate(objectToClone);
			Debug.Log("Clonaste un cubo");
			cont++;
		}
	}
}
