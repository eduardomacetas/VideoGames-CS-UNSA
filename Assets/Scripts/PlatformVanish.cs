using UnityEngine;
using System.Collections;

public class PlatformVanish : MonoBehaviour {
 
	Animator animator;
	public GameObject character;
	int collisionTime=0;
	//public GameObject platform;

	// Use this for initialization
	void Start () {
		animator=GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.OverlapSphere (character.transform.position,0.509f,LayerMask.GetMask("PlatformVanish")).Length>0 && animator.GetBool ("Collision")== false) {
			animator.SetBool ("Collision", true);
			collisionTime = Time.frameCount;
		}
		if (animator.GetBool ("Collision")) {
			if(Time.frameCount == collisionTime+110){
				animator.SetBool ("Collision", false);
			}
		}
	}
}
