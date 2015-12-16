using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject applePrefab;
	public float speed = 1f;
	public float leftAndRightEdge = 10f;
	public float chanceToChangeDirections = 0.1f;
	public float secondsBetweenAppleDrops = 1f;

	void Start(){
		//Dropping apples every second
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}
	void DropApple(){
		GameObject Apple = Instantiate (applePrefab) as GameObject;
		Apple.transform.position = transform.position;
	}

	void Update(){
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //Move Right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); //Move Left
		} 
	}

	void FixedUpdate(){
		if (Random.value < chanceToChangeDirections) {
			speed *=-1; //Change Direction
		}
	}
}
