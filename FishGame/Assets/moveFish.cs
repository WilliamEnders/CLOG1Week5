using UnityEngine;
using System.Collections;

public class moveFish : MonoBehaviour {

	public bool fishFocus;
	private Transform ballPos;
	private float randomY;

	// Use this for initialization
	void Start () {
		fishFocus = false;
		ballPos = GameObject.Find ("ball").transform;
		randomY = Random.Range (-9f, 1.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fishFocus) {
			if(ballPos.gameObject.GetComponent<moveSphere>().fishGrab == false){
				if (transform.position.y <= 2.72f) {
					transform.LookAt (ballPos.position);
					transform.position += transform.forward * 1f * Time.deltaTime;
				}
			}else{
				transform.position = ballPos.position;
			}
		} else {
			transform.LookAt (new Vector3(100,randomY,0));
			transform.position += transform.forward * 1f * Time.deltaTime;
		}
	}
}
