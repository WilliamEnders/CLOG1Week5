using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {

		ball = GameObject.Find ("ball");
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = ball.GetComponent<moveSphere>().score.ToString();
	}
}
