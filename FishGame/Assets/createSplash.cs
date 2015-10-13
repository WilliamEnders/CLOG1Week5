using UnityEngine;
using System.Collections;

public class createSplash : MonoBehaviour {

	public GameObject splash;

	void OnTriggerEnter(Collider other) {
		Instantiate (splash,other.transform.position,new Quaternion(-180,0,0,0));
	}
}
