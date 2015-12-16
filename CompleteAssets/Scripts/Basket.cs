using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Basket : MonoBehaviour {
	//public Text scoreGT;

	// Update is called once per frame
	void Update () {
	//Get the current screen position of the mouse from Input
		Vector3 mousePos2D = Input.mousePosition;
	//The Camera's z position sets the how far to push the mouse into 3D
		mousePos2D.z = -Camera.main.transform.position.z;
	//Convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);
	//Move the x position of this Basket to the x position of the Mouse 
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}
	
	void Start(){
		//Find a reference to the ScoreCounter GameObject
		//GameObject scoreGO = GameObject.Find ("ScoreCounter");
		//Get the GUIText Component of that GameObject
		//scoreGT = scoreGO.GetComponent(Text);
			//scoreGT.text ="0";
	}
	void OnCollisionEnter(Collision coll){
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Apple") {
			Destroy (collidedWith);
		}
		//int score = int.Parse (scoreGT.text);
		//score += 100;
		//scoreGT.text = score.ToString ();
	}
	}

