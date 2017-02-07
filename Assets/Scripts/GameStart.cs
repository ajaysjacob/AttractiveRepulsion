using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	public GameObject Player= GameObject.FindGameObjectWithTag ("Player");
	public Rigidbody Plyr;
	void Start () {
		Player= (GameObject) GameObject.FindGameObjectWithTag ("Player");
		Plyr= Player.GetComponent<Rigidbody>();
	}


	void Update () {
		if (Input.GetButtonDown("Launch")) {
			Plyr.velocity= new Vector3(1,0,0);
		}

	}
}
