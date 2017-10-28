using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public float livetime;
	void Start()
	{
		Destroy (gameObject, livetime);
	}
}
