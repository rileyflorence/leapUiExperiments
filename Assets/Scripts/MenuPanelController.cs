using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelController : MonoBehaviour {

    public Animator menuSummon;

	// Use this for initialization
	void Start () {
        menuSummon.SetBool("Shown", false);
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    public void ShowMenu()
    {
        menuSummon.SetBool("Shown", true);
    }

    public void HideMenu()
    {
        menuSummon.SetBool("Shown", false);
    }

    public void ProfileActivate()
    {
        menuSummon.SetBool("profile", true);
    }


}
