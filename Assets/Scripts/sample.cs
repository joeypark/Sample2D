using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sample : MonoBehaviour {

    public InputField nameField;
    public Text logField;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnBtnOK()
    {
        StartCoroutine(coNameEnter());
    }

    IEnumerator coNameEnter()
    {
        string inputNameURL = string.Format("http://localhost/userNameAction.php?name={0}", nameField.text);
        inputNameURL = inputNameURL.Replace(" ", "+");
        WWW www = new WWW(inputNameURL);
        yield return www;

        logField.text = www.text;
    }
}
