using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public GameObject asteroid;
	public int asteroidCount;

	// Use this for initialization
	void Start () {
		this._AsteroidStart ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// adds cloudCount clouds to the scene
	private void _AsteroidStart() {
		for (int count=0; count< this.asteroidCount; count++) {
			Instantiate(asteroid); // add a cloud to the scene
		}
	}
}
