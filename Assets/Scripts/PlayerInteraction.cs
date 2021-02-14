using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
public float Horizontal;
public float Vertical;
public Rigidbody2D rb2d;
public float e;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Horizontal = Input.GetAxis("Horizontal");
		Vertical = Input.GetAxis("Vertical");

		rb2d.AddForce(new Vector2(Horizontal*e, Vertical*e));
	}
}
