using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePotion : MonoBehaviour {

    public Transform potion;
    public Transform menu;

	public void MakePotion()
    {
        Instantiate(potion, menu.position + new Vector3(-.05f, 0.06f, -.12f), Quaternion.identity);
    }
}
