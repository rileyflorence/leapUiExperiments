using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLocation : MonoBehaviour {

    public Transform palmLocation;
    public Transform menuLocation;
    public Transform player;

	public void SetMenuLocation ()
    {
        menuLocation.position = palmLocation.position + new Vector3 (0, 0.25f, 0);
        menuLocation.LookAt(player.position + new Vector3 (0, 0.05f, 0));
    }

}
