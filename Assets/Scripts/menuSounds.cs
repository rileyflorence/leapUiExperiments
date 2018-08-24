using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSounds : MonoBehaviour {

    public AudioSource menuFX;
    public AudioClip openMenu;
    public AudioClip closeMenu;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void HoverSound()
    {
        menuFX.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        menuFX.PlayOneShot(clickFx);
    }

    public void OpenMenuSound()
    {
        menuFX.PlayOneShot(openMenu);
    }

    public void CloseMenuSound()
    {
        menuFX.PlayOneShot(closeMenu);
    }
}
