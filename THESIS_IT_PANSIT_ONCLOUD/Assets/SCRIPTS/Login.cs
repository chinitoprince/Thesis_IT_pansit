using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour {

	public Text  inputusername  ;
	public Text inputpassword  ;
	public Text inputmonth;
	public Text inputday;
	public Text inputyear;
	public string inputusername1;
	public string inputpassword1;
	public string Dob;
	string LoginURL = "localhost/thesis/Login.php";


	// Use this for initialization
	//void Start () {
		
	//}
	public void LOGIN ()	
	{
		inputusername1 = inputusername.text;
		inputpassword1 = inputpassword.text;
		Dob = inputmonth.text + " " + inputday.text + "," + inputyear.text;
		//if (Input.GetKeyDown (KeyCode.KeypadEnter))
			StartCoroutine(LoginToDB (inputusername1, inputpassword1, Dob));
	}
	// Update is called once per frame
	//void Update () {
		
	
		
	//}

	IEnumerator LoginToDB(string Username, string Password, string Dob){
	WWWForm form = new WWWForm ();
	form.AddField("UsernamePost", Username);
	form.AddField("PasswordPost", Password);
	form.AddField("DobPost", Dob);
	WWW www = new WWW (LoginURL, form);

	yield return www;

	Debug.Log(www.text);
		if (www.text == "login success") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
		else if (www.text == "Welcome Admin")
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);

		}
}
}
