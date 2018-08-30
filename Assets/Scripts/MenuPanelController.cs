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
        menuSummon.SetBool("SettingsSelected", false);
        menuSummon.SetBool("LeftOnce", false);
        menuSummon.SetBool("LeftTwice", false);
        menuSummon.SetBool("Panel2IsOpen", false);
        menuSummon.SetBool("ProfileSelected", false);
    }

    public void ProfileActivate()
    {
        menuSummon.SetBool("ProfileSelected", true);
    }

    public void ProfileDeactivate()
    {
        menuSummon.SetBool("ProfileSelected", false);
    }

    public void SetPanel2()
    {
        menuSummon.SetBool("Panel2IsOpen", true);
    }

    public void UnsetPanel2()
    {
        menuSummon.SetBool("Panel2IsOpen", false);
    }


    public void SetLeftOnce()
    {
        menuSummon.SetBool("LeftOnce", true);
    }

    public void UnsetLeftOnce()
    {
        menuSummon.SetBool("LeftOnce", false);
    }


}
