using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToggle : MonoBehaviour
{
    public void OnValueChange()
    {
        Debug.Log("Toogle is: " + gameObject.GetComponent<Toggle>().isOn);
    }
}
