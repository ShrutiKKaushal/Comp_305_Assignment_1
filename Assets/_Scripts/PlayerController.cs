﻿/* Author: Shruti K. Kaushal */
/* File: PlayerController.cs */
/* Creation Date: 29 Oct, 2015 */
/* Description: This script controls the player gameObject's movement */

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public Vector2 move = new Vector2 (0.0f, 0.0f);
	public Boundary boundary;

	public Camera camera;
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		 

	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();

	}

	// checkInput method
	private void _CheckInput() {

		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position

		

		// player object follows mouse position
		Vector2 mousePosition = Input.mousePosition;
		this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;

		// boundary check
		if ((this._newPosition.x) < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}

		if ((this._newPosition.x) > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
			//gameObject.GetComponent<Transform>().position = this._newPosition;
		}
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}
}
