using UnityEngine;
using System.Collections;

public class PlatformOpen : MonoBehaviour {
 
	Animator animator;
	int startTime=20;

	// Use this for initialization
	void Start () {
		animator=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.frameCount == startTime) {
			animator.SetBool ("Open", true);
		}
			
	}
}
