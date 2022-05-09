using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
	public GameObject objectToClone;

	public void CloneObject()
	{
		Instantiate(objectToClone);
		Instantiate(objectToClone);
		Instantiate(objectToClone);
		Instantiate(objectToClone);
		Instantiate(objectToClone);
	}
}
