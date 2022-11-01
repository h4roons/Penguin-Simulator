using UnityEngine;
using System.Collections;

public class PenguinUserController : MonoBehaviour {
	PenguinCharacter penguinCharacter;
	
	void Start () {
		penguinCharacter = GetComponent <PenguinCharacter> ();
	}
	
	void Update () {	
		if (ControlFreak2.CF2Input.GetButtonDown ("Fire1")) {
			penguinCharacter.Attack();
		}
		
		if (ControlFreak2.CF2Input.GetButtonDown ("Jump")) {
			penguinCharacter.Jump();
		}
		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.H)) {
			penguinCharacter.Hit();
		}
		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.E)) {
			penguinCharacter.Eat();
		}
		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.K)) {
			penguinCharacter.Death();
		}
		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.R)) {
			penguinCharacter.Rebirth();
		}		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.Y)) {
			penguinCharacter.StandUp();
		}
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.G)) {
			penguinCharacter.Grooming();
		}		
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.F)) {
			penguinCharacter.Flap();
		}

		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.T)) {
			penguinCharacter.Toboggan();
		}				
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.V)) {
			penguinCharacter.Dive();
		}	
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.C)) {
			penguinCharacter.CatchTheRock();
		}	
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.R)) {
			penguinCharacter.ReleaseTheRock();
		}	

		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.I)) {
			penguinCharacter.SwimStart();
		}	

		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.M)) {
			penguinCharacter.SwimEnd();
		}	


	}
	
	private void FixedUpdate()
	{
		float h = ControlFreak2.CF2Input.GetAxis ("Horizontal");
		float v = ControlFreak2.CF2Input.GetAxis ("Vertical");
		if (ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift)) v *= 0.5f;
		penguinCharacter.Move (v,h);
	}
}
