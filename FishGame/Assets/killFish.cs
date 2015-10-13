using UnityEngine;
using System.Collections;

public class killFish : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider collisionInfo) {
	
		Destroy (collisionInfo.gameObject);

	}
}
