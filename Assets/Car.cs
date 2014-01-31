using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	float speed;
	
	// Update is called once per frame
	void Update () {
		float rotateY = Input.GetAxis("Horizontal") * 200;
		float translateZ = Input.GetAxis("Vertical") * 2;
		
		speed += translateZ;
		if (speed > 30)
		{
			speed = 30;
		}
		if (speed < -30)
		{
			speed = -30;
		}
		
		transform.Translate(0, 0, speed * Time.deltaTime);
		if (translateZ != 0)
		{
			transform.Rotate(0, rotateY * Time.deltaTime, 0);
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.name == "Cube" || col.collider.name == "Banananah")
		{
			Color clr = new Color();
			
			clr.r = Random.value;
			clr.g = Random.value;
			clr.b = Random.value;
			clr.a = Random.value;
			
			col.collider.renderer.material.color = clr;
			
			GameObject.Find("Car/Base").renderer.material.color = clr;
		}
	}
}
