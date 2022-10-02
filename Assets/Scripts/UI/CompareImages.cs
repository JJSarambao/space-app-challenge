using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CompareImages : MonoBehaviour
{
    public Image otherTelescopes;
    public Sprite[] imagesByOtherTelescopes;

    private int index = 0;

    public void ScrollLeft()
    {
        index = (index - 1 < 0) ? imagesByOtherTelescopes.Length - 1 : index - 1;
        otherTelescopes.sprite = imagesByOtherTelescopes[index];
    }

    public void ScrollRight()
    {
        index = (index + 1) % imagesByOtherTelescopes.Length;
        otherTelescopes.sprite = imagesByOtherTelescopes[index];
    }
}
