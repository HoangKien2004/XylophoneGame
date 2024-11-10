using System;
using UnityEngine;

public class Tone : MonoBehaviour
{
    public static event Action<string> ToneClicked = delegate { };
    private void OnMouseDown()
    {
        ToneClicked(name);
    }
}
