using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {


	bool mSpecial=false;
	bool mOrigin=false;
	bool mTarget=false;

	double mSize;

	// Use this for initialization
	void Start () {
		//mSize = 50;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	bool isOrigin(){
		return mOrigin;
	}

	bool isTarget(){
		return mTarget;
	}

	bool isSpecial(){
		return mSpecial;
	}

	public virtual void Draw(){
	}


	public virtual void Activate (){
	}



}
