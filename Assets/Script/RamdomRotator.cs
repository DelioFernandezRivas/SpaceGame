using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomRotator : MonoBehaviour {
	private Rigidbody rb;
	public float tunble;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere* tunble;



	}

}