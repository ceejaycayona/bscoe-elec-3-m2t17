using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rocket : MonoBehaviour {

	Rigidbody _rigidbody;
	public Color color = Color.green;
	public Renderer rend;
	public Material material;
	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput ();
	}

	private void ProcessInput(){
		if (Input.GetKey (KeyCode.Space))
		{
			_rigidbody.AddRelativeForce (Vector3.up*30);
			print ("fly");
		}
		if (Input.GetKey (KeyCode.A))
		{
			
			transform.Rotate(Vector3.forward*3);
			print ("left");
		}
		if (Input.GetKey (KeyCode.D))
		{
			
			transform.Rotate(-Vector3.forward*3);
			print ("right");
		}

	}

	void OnCollisionEnter(Collision collisionInfo)
	{

		if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "obstacle")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
			
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		else if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "Terrain")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);

			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		else if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "background")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);

			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		else if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "wall")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
				
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		else if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "ceiling")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		else if(gameObject.name =="Rocket Ship" && collisionInfo.collider.name == "Target Pad")
		{
			print ("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
			collisionInfo.gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}
	}
}
