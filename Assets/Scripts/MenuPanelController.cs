using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    public void translatePanel()
    {
        transform.Translate(Vector3.right * .5f);
    }
}
