using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class AlterText : MonoBehaviour
{
    [SerializeField] public TMP_Text dialogOne;
    [SerializeField] public TMP_InputField textInput;
    [SerializeField] public GameObject btnNext;
    [SerializeField] public GameObject btnSearch;
    [SerializeField] public float characterCooldown = 0.05f;
    [SerializeField] private float timeCounter;
    [SerializeField] private int characterCounter;

    

    void Start()
    {
        timeCounter = Time.time;
        characterCounter = 0;
        
    }

    void Update()
    {


        string text = textInput.text;
        char[] w = textInput.text.ToCharArray();
        char c = dialogOne.text[0];

        for (int x = 0; x < w.Length; x++)
        {
            if (w[x].Equals(c))
            {
                string s = w[x].ToString();
                text = text.Replace(s, "<color=red>" + s + "</color>");
            }
        }
        dialogOne.text = text;

        /*

        //setando o texto invisivel
        if (dialogOne.maxVisibleCharacters != characterCounter)
        {
            dialogOne.maxVisibleCharacters = characterCounter;
        }

        TMP_TextInfo textInfo = dialogOne.textInfo;
        
        if (characterCounter < textInfo.characterCount)
        {
            TMP_CharacterInfo charInfo = textInfo.characterInfo[characterCounter];
            if (charInfo.character == ' ')
            {
                characterCounter++;
            }
        }

        if(Time.time > timeCounter + characterCooldown)
        {
            timeCounter = Time.time;
            characterCounter++;
        }

        if(characterCounter > dialogOne.text.Length)
        {
            this.enabled = false;
        }

        */


    }
}
