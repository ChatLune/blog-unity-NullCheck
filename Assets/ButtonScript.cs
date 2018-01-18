using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public GameObject myObject;
	public int count;
	public AudioClip audioClip;
	public Button button;
	public AudioSource audioSource;

	void Awake () {
		myObject = GameObject.Find ("GameObject");
		ShowName ();
		AddCount ();
//		myObject.GetComponent< Button> ().enabled = false;
		if (audioClip != null) {
			Debug.Log (audioClip.length);
		} else {
			Debug.Log ("audioClip is Null!");
		}
		if (audioSource != null) {
			audioSource.clip = audioClip;
			audioSource.Play ();
		} else {
			Debug.Log ("audioSource is Null!");
		}
		Debug.Log ("ほげほげ");
	}

	void Start(){
		button.GetComponentInChildren<Text> ().text = "ほげる";
	}

	public void ShowName(){
		Debug.Log (myObject.name);
	}

	public void AddCount(){
		count++;
		Debug.Log (count);			
	}
}
