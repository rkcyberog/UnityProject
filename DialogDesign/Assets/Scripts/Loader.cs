using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Loader : MonoBehaviour {


	public Button scene1Button;
	public Button scene2Button;
	public Button scene3Button;
	public Button Show;
	public Button Print;
	Scene scene;
	// Use this for initialization
	void Start () {
		 scene = SceneManager.GetActiveScene();
		Button btnScene1 = scene1Button.GetComponent<Button>();
		Button btnScene2 = scene2Button.GetComponent<Button>();
		Button btnScene3 = scene3Button.GetComponent<Button>();
		Button show = Show.GetComponent<Button>();
		Button print = Print.GetComponent<Button>();
		btnScene1.onClick.AddListener(loadScene1);
		btnScene2.onClick.AddListener(loadScene2);
		btnScene3.onClick.AddListener(loadScene3);
		show.onClick.AddListener(loadDialog);
		print.onClick.AddListener(printScene);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void loadScene1(){
		Debug.Log("Scene1");
		SceneManager.LoadScene("Scene 1", LoadSceneMode.Single);
	}

	void loadScene2(){
		Debug.Log("Scene2");
		SceneManager.LoadScene("Scene 2", LoadSceneMode.Single);
	}

	void loadScene3(){
		Debug.Log("Scene3");
		SceneManager.LoadScene("Scene 3", LoadSceneMode.Single);
	}
	void loadDialog(){
		Debug.Log ("show");
		DialogManager.instance.Show ();
	}
	void printScene(){
		Debug.Log ("Active Scene is " + scene.name);

	}

}
