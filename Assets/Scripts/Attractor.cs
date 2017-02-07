using UnityEngine;
using System.Collections;

public class Attractor : MonoBehaviour {

	public float a;
	public GameObject Player;
	public Rigidbody Plyr;
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		Plyr = Player.GetComponent<Rigidbody>();
	}

	void Update () {
		if (Player.transform.position != Vector3.zero) {
			Vector3 r = (Vector3) Player.transform.position - transform.position;
			Plyr.AddForce ((-a / (Mathf.Pow (Vector3.Magnitude (r), 3))) * r);
		} 
	}
}
