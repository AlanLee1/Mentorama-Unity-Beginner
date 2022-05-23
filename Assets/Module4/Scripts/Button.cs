using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void OnClickButton(){
        gameObject.GetComponent<Text>().text = "Mentorama";
    }
}
