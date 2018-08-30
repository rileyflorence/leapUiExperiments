using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorOnActive : MonoBehaviour {

    private SimpleInteractionGlow _parentScript;
    SpriteRenderer m_SpriteRenderer;
    public Color defaultColor = new Color(.2f, .2f, .2f, .2f);
    public Color selectedColor = new Color(1f, 1f, 1f, .9f);

    // Use this for initialization
    void Start () {
        _parentScript = transform.parent.GetComponent<SimpleInteractionGlow>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = defaultColor;
    }
	
	// Update is called once per frame
	void Update () {
        if (_parentScript.isSelected)
        {
            m_SpriteRenderer.color = selectedColor;
        }
        else
        {
            m_SpriteRenderer.color = defaultColor;
        }
	}
}
