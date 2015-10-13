using UnityEngine;
using System.Collections;

public class fishSpawner : MonoBehaviour {

	public GameObject fish;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnFish", 0f, 5f);
	}

	void spawnFish(){
		Instantiate (fish,new Vector3(-15,Random.Range(-7.5f,1.5f),0),transform.rotation);
	}
}
