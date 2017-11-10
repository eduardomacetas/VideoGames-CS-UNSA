using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	float jumpTime = 20f;
	float jumpPower = 20f;
	bool isMovable= true;
	bool hasMovement =false;

	Vector3 position;


	// Use this for initialization
	void Start () {
	
	}

	void JumpForward(Vector3 targetPos)
	{
		Vector3 startPos= transform.position;
		float height = 0;
		float verticalVelocity= jumpPower;
		float curTime = 0;
		while(curTime < jumpTime)
		{
			height += verticalVelocity * Time.deltaTime;
			verticalVelocity = Mathf.Lerp(jumpPower, -jumpPower, curTime / jumpTime);
			Vector3 basePos = Vector3.Lerp(startPos, targetPos, curTime / jumpTime);
			Vector3  resultantPos  = basePos + (Vector3.up * height);
			transform.position = resultantPos;
			curTime += Time.deltaTime;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (hasMovement && position.y>=transform.position.y) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f, GetComponent<Rigidbody> ().velocity.y, 0f);
			hasMovement = false;
			isMovable = true;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {


			//JumpForward (new Vector3 (transform.position.x+1f, 0f, transform.position.z));

			GetComponent<Rigidbody> ().velocity = new Vector3 (2.083334f, 3.6f, 0f);
			position=transform.position;
			hasMovement= true;
			isMovable = false;

		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (-2.083334f, 3.6f, 0f);
			position=transform.position;
			hasMovement= true;
			isMovable = false;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 3.6f, 2.083334f);
			position=transform.position;
			hasMovement= true;
			isMovable = false;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 3.6f, -2.083334f);
			position=transform.position;
			hasMovement= true;
			isMovable = false;
		}
	
	}
}
