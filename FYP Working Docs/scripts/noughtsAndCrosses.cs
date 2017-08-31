using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class noughtsAndCrosses : MonoBehaviour, IVirtualButtonEventHandler  {

	public GameObject[] button;

	public List<GameObject> spriteHolder;

	public Sprite goodBacteria;
	public Sprite badBacteria;

	private bool player1Turn;

	void Start() {
		
		player1Turn = true;

		for (int i = 0; i < button.Length; i++) {

			button[i].GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		}

	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

		if (player1Turn) {

			playerOnesTurn ();
			displaySprite (vb);

		} else {
			playerTwosTurn ();
			displaySprite (vb);
		}


	}

	private void playerOnesTurn() {

		changeSprite (goodBacteria);

		player1Turn = false;

	}

	private void playerTwosTurn() {

		changeSprite (badBacteria);

		player1Turn = true;

	}

	private void changeSprite(Sprite changeTo) {
		foreach (GameObject o in spriteHolder) {

			GameObject obj = (GameObject)o;
			obj.GetComponent<SpriteRenderer> ().sprite = changeTo;

		}
	}

	private void displaySprite(VirtualButtonAbstractBehaviour vb) {

		GameObject obj;

		if (vb.name == "VirtualButton") {
			obj = (GameObject)spriteHolder [0];
			obj.SetActive (true);
			spriteHolder.RemoveAt (0);
		} else if (vb.name == "VirtualButton1") {
			obj = (GameObject)spriteHolder [1];
			obj.SetActive (true);
			spriteHolder.RemoveAt (1);
		} else if (vb.name == "VirtualButton2") {
			obj = (GameObject)spriteHolder [2];
			obj.SetActive (true);
			spriteHolder.RemoveAt (2);
		} else if (vb.name == "VirtualButton3") {
			obj = (GameObject)spriteHolder [3];
			obj.SetActive (true);
			spriteHolder.RemoveAt (3);
		} else if (vb.name == "VirtualButton4") {
			obj = (GameObject)spriteHolder [4];
			obj.SetActive (true);
			spriteHolder.RemoveAt (4);
		} else if (vb.name == "VirtualButton5") {
			obj = (GameObject)spriteHolder [5];
			obj.SetActive (true);
			spriteHolder.RemoveAt (5);
		} else if (vb.name == "VirtualButton6") {
			obj = (GameObject)spriteHolder [6];
			obj.SetActive (true);
			spriteHolder.RemoveAt (6);
		} else if (vb.name == "VirtualButton7") {
			obj = (GameObject)spriteHolder [7];
			obj.SetActive (true);
			spriteHolder.RemoveAt (7);
		} else if (vb.name == "VirtualButton8") {
			obj = (GameObject)spriteHolder [8];
			obj.SetActive (true);
			spriteHolder.RemoveAt (8);
		} else if (vb.name == "VirtualButton9") {
			obj = (GameObject)spriteHolder [9];
			obj.SetActive (true);
			spriteHolder.RemoveAt (9);
		}

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

	}




}
