using UnityEngine;
using System.Collections;

public class moveAround : MonoBehaviour {

	public float speed;
	private GameObject ball;

	// Use this for initialization
	void Start () {
	ball = GameObject.Find ("ball");
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.GetComponent<moveSphere> ().waterHit == false) {
			if(ball.GetComponent<moveSphere> ().isCast == false){
			transform.position += Vector3.right * speed * Time.deltaTime * Input.GetAxis ("Horizontal");
			}
		} else {
			transform.position = new Vector3(ball.transform.position.x,2.72f,0f);
		}
	}
}
