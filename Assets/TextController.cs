using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "Hallo Wereld";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        print (text.text = "Spatie is ingedrukt");
    }
}
