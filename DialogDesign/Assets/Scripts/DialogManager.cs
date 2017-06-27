using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {
	public GameObject DialogObject;
	public static DialogManager instance = null;

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Show(){
		Debug.Log("DialogShow");
		//DialogObject.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
		DialogObject.GetComponent<Dialog>().ShowDialog();
	}
}
