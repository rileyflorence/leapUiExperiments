using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLocation : MonoBehaviour {

    public Transform palmLocation;
    public Transform menuLocation;
    public Transform player;

	public void SetMenuLocation ()
    {
        menuLocation.LookAt(player.position + new Vector3(0, 0.02f, 0));
        menuLocation.position = palmLocation.position + new Vector3 (0, 0.3f, 0);
    }

}
