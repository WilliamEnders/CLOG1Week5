using UnityEngine;
using System.Collections;

public class touchBall : MonoBehaviour {
	void OnTriggerEnter(Collider collisionInfo){
		if(collisionInfo.gameObject.tag == "Fish"){
			transform.parent.GetComponent<moveSphere>().fishGrab = true;
		}
	}
}
