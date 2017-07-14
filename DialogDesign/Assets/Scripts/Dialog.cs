using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Dialog : MonoBehaviour {
	Scene scene;
	public GameObject icon1;
	public GameObject icon2;
	public Text titleText;
	public Text Desc;
	public Button yesButton;
	public Button noButton;
	public Button buyButton;
	public Button close;
	public GameObject gameObjectYes;
	public GameObject gameObjectNo;
	public GameObject gameObjectBuy;
	public GameObject gameObjectClose;
	//public Text responseText;
	//public GameObject gameObjectTitle;
	//public GameObject gameObjectDesc;
	public GameObject gameObjectResponse;
	public RectTransform DialogBox;
	public GameObject gameObjectDialog;

	// Use this for initialization
	void Start () {
		
		Debug.Log (scene.name);
		titleText = GetComponent<Text> ();
		Desc = GetComponent<Text> ();
		//responseText = GetComponent<Text> ();
		Button btnYes = yesButton.GetComponent<Button>();
		Button btnNo = noButton.GetComponent<Button>();
		Button btnBuy = buyButton.GetComponent<Button>();
		Button btnClose = close.GetComponent<Button>();
		btnYes.onClick.AddListener(Yes);
		btnNo.onClick.AddListener(No);
		btnBuy.onClick.AddListener(Buy);
		btnClose.onClick.AddListener(Close);

	}

	// Update is called once per frame
	void Update () {
		
	}

	public void ShowDialog(){
		scene = SceneManager.GetActiveScene();
		//LightBackground.SetActive (true);
		//DialogBox.SetActive (true);
		//gameObjectTitle.SetActive (true);
		//gameObjectDesc.SetActive (true);

		Debug.Log ("DialogCs");
		Debug.Log (scene.name);
		if (scene.name == "Scene 1") {
			//gameObjectDialog.GetComponent<EasyTween> ().rectTransform = DialogBox;
			gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();

			gameObjectYes.SetActive (true);
			gameObjectNo.SetActive (true);
			gameObjectClose.SetActive (true);
			icon1.SetActive (true);
			titleText.text = "Scene 1";
			Desc.text = "Scene 1 dialog has two button.";


		} else if (scene.name == "Scene 2") {
			gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
			gameObjectClose.SetActive (true);
			icon2.SetActive (true);
			titleText.text = "Scene 2";
			Desc.text = "Scene 2 dialog has no button.";

		} else if (scene.name == "Scene 3") {
			gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
			gameObjectBuy.SetActive (true);
			icon1.SetActive (true);
			titleText.text = "Scene 3";
			Desc.text = "Scene 3 dialog has one button and no close button.";

		}
	}

	void Yes(){
		Debug.Log("Yes");
		gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
		Instantiate (gameObjectResponse);
		gameObjectResponse.GetComponent<Text> ().text = "Yes";
		//gameObjectResponse.SetActive (true);
		//LightBackground.SetActive (false);
		//DialogBox.SetActive (false);

		//responseText.text = "Yes";
	}
	void No(){
		Debug.Log("No");
		gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
		Instantiate (gameObjectResponse);
		gameObjectResponse.GetComponent<Text> ().text = "No";
		//gameObjectResponse.SetActive (true);
		//LightBackground.SetActive (false);
		//DialogBox.SetActive (false);
		//responseText.text = "No";
	}
	void Buy(){
		Debug.Log("Buy");
		gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
		Instantiate (gameObjectResponse);
		gameObjectResponse.GetComponent<Text> ().text = "Buy";
		//gameObjectResponse.SetActive (true);
		//LightBackground.SetActive (false);
		//DialogBox.SetActive (false);
		//responseText.text = "Buy";

	}
	void Close(){
		Debug.Log("Close");
		gameObjectDialog.GetComponent<EasyTween> ().OpenCloseObjectAnimation ();
		var respawn = GameObject.FindWithTag ("Respawn");
		Instantiate (gameObjectResponse);
		gameObjectResponse.GetComponent<Text> ().text = " ";
		//gameObjectResponse.SetActive (true);
		//LightBackground.SetActive (false);
		//DialogBox.SetActive (false);
		//responseText.text = " ";
	}
}
