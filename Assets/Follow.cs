using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(GameObject.Find("Car").transform.position);
	}
}
