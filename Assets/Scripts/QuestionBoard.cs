using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBoard : MonoBehaviour {
	private bool isDown = true;
	private Animator anim;
	private int downHash = Animator.StringToHash("MoveDown");
	private int upHash = Animator.StringToHash("MoveUp");

	void Start() {
		anim = GetComponent<Animator>();
	}

	public void moveUp() {
		if (isDown) {
			anim.SetTrigger(upHash);
			isDown = !isDown;
		}
	}

	public void moveDown() {
		if (!isDown) {
			anim.SetTrigger(downHash);
			isDown = !isDown;
		}
	}

	void OnMouseDown() {
		if ( isDown ) moveUp();
		else moveDown();
	}
}
