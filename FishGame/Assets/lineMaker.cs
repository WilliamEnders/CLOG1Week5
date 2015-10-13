using UnityEngine;
using System.Collections;

public class lineMaker : MonoBehaviour {

	private Transform bait;
	LineRenderer line;

	// Use this for initialization
	void Start () {

		bait = GameObject.Find ("ball").transform;
		line = transform.GetComponent<LineRenderer> ();
		line.SetVertexCount (2);
		line.SetPosition (0, transform.position);
	
	}
	
	// Update is called once per frame
	void Update () {
		line.SetPosition (1, bait.position);
	
	}
}
