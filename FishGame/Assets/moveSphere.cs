using UnityEngine;
using System.Collections;

public class moveSphere : MonoBehaviour {

	private Transform targetPos;
	private Transform polePos;
	public bool isCast;
	public bool waterHit;
	public bool fishGrab;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		targetPos = GameObject.Find ("target").transform;
		polePos = GameObject.Find ("poletop").transform;
		isCast = false;
		waterHit = false;
		fishGrab = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isCast && !waterHit) {
			transform.LookAt (targetPos.position);
			transform.position += transform.forward * 10f * Time.deltaTime;
		} else {
			if(Input.GetKeyDown(KeyCode.Space)){
				isCast = true;
			}
		}
		if(transform.position.y <= targetPos.position.y){
			waterHit = true;
		}
		if(waterHit){
			transform.LookAt (polePos.position);
			if(transform.position.y >= -7.5f){
			transform.position += -Vector3.up * 1f * Time.deltaTime ;
			}
			if(Input.GetKey(KeyCode.Space) && !fishGrab){
				transform.position += transform.forward * 5f * Time.deltaTime;
			}
			if(Input.GetKeyDown(KeyCode.Space) && fishGrab){
				transform.position += transform.forward * 15f * Time.deltaTime;
			}
			if(transform.position.y >= polePos.position.y){
				waterHit = false;
				isCast = false;
			}
		}
	}

	void OnTriggerEnter(Collider collisionInfo){
		if(collisionInfo.gameObject.tag == "Fish" && !fishGrab){
			collisionInfo.gameObject.GetComponent<moveFish>().fishFocus = true;
		}
	}
	void OnTriggerExit(Collider collisionInfo){
		if(collisionInfo.gameObject.tag == "Fish" && !fishGrab){
			collisionInfo.gameObject.GetComponent<moveFish>().fishFocus = false;
		}
	}
}
