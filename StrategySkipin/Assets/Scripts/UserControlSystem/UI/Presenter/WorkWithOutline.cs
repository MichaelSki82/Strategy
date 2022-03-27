using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class WorkWithOutline : MonoBehaviour
{
    private Outline _outline;

    private void OnEnable()
    {
        _outline = GetComponent<Outline>();
        Debug.Log("close outline");
        _outline.OutlineWidth = 0;

    }

    public void OutlineActivation()
    {
        _outline.OutlineWidth = 6;
    }

    public void OutlineDeactivation()
    {
        _outline.OutlineWidth = 0;
    }
}
