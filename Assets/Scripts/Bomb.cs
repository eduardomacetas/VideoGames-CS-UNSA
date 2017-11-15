using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    private Rigidbody mRb;

    // position in maze
    int mX;
	int mY;

	//true = is alive; false = is dead
	bool mStatus=true;
    
	// Use this for initialization
	void Start () {
		mPosition = transform.position;
		mRb = GetComponent<Rigidbody> ();
	}

	void setPosition(int newX, int newY){
		mX = newX;
		mY = newY;
	}

	void setStatus(bool newStatus){ mStatus = newStatus; }

	bool status(){	return mStatus; }

	int x(){  return mX; }
	int y(){  return mY; }



	bool mIsMovable= true;

	// 1= right 2=left 3=up 4 =down
	int mDirection =0;

	const float mDistanceToJump =1.2f;
	Vector3 mPosition;
	bool mHasCollision;




	// Update is called once per frame
	void Update () {
		
		//if (!isMovable && mPosition.y>=transform.position.y) {
		if (mHasCollision){
			//mHasCollision = false;
			mRb.velocity = new Vector3 (0f,0f, 0f);
			mRb.position = mPosition;
			mIsMovable = true;

		}


		if ((mDirection!= 0) && mIsMovable) {
							
			if(mDirection == 1){
				mRb.velocity = new Vector3 (1.665f, 3.6f, 0f);
				mPosition = new Vector3 (mPosition.x+mDistanceToJump,mPosition.y,mPosition.z);
			

			}
			else if(mDirection == 2){
				mRb.velocity = new Vector3 (-1.665f, 3.6f, 0f);
				mPosition = new Vector3 (mPosition.x-mDistanceToJump,mPosition.y,mPosition.z);
			}
			else if(mDirection == 3){
				mRb.velocity = new Vector3 (0f, 3.6f, 1.665f);
				mPosition = new Vector3 (mPosition.x,mPosition.y,mPosition.z+mDistanceToJump);
			}
			else if(mDirection == 4){
				mRb.velocity = new Vector3 (0f, 3.6f, -1.665f);
				mPosition = new Vector3 (mPosition.x,mPosition.y,mPosition.z-mDistanceToJump);
			}

			mHasCollision = false;
			mIsMovable = false;


		}


		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			mDirection = 1;

		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			mDirection = 2;
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			mDirection = 3;
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			mDirection = 4;
		}
		
	}


	void OnCollisionEnter (Collision col)
	{
		mHasCollision = true;
	}
}

