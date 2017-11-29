using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool ballLaunched;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		ballLaunched = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!ballLaunched) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, launch ball");
				ballLaunched = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		} 
		
	}
}
