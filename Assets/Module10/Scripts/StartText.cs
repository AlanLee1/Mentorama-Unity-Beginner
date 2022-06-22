using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartText : MonoBehaviour
{
    [Header("Objetos")]
    [SerializeField] public TMP_Text dialogOne;
    [SerializeField] public TMP_InputField textInput;
    [SerializeField] public GameObject btnNext;
    [SerializeField] public GameObject btnSearch;
    [SerializeField] public TMP_Text targetTemp;
    [SerializeField] public TMP_Text textoTemp;

    [Header("Variaveis")]
    [SerializeField] public float characterCooldown = 0.05f;
    [SerializeField] private float timeCounter;
    [SerializeField] private int characterCounter;
    [SerializeField] public Gradient color;
    int cont;
    float variavelCor;

    void Start()
    {
        timeCounter = Time.time;
        characterCounter = 0;
        textInput.text = "of";
        cont = 1;

        /*A galley of type and scrambled it to make a type ageMaker including versions of Lorem Ipsum.*/
                      
    }

    void Update()
    {
        variavelCor = Random.Range(0f, 1f);
        try
        {
            

            int posInicial = dialogOne.text.IndexOf(textInput.text.ToString());
            string target = dialogOne.text.Substring(posInicial, textInput.text.ToString().Length);
            string leftOverString = dialogOne.text.Substring(posInicial + textInput.text.ToString().Length);
            string alReadyRead = dialogOne.text.Substring(0, posInicial);
            dialogOne.text = "";
            do
            {
                //trocou a cor do "of"
                dialogOne.color = color.Evaluate(variavelCor);

                dialogOne.text += alReadyRead;
                dialogOne.text += target;

                Debug.Log("Já lido: " + alReadyRead); // A galley
                //Debug.Log("Passei no While " + cont + " vezes");
                Debug.Log("PosInicial: " + posInicial); // 9
                Debug.Log("TARGET: " + target); // of
                Debug.Log("Resto da String: " + leftOverString); // o resto pra frente

                posInicial = leftOverString.IndexOf(textInput.text.ToString());
                target = leftOverString.Substring(posInicial, textInput.text.ToString().Length);
                alReadyRead = leftOverString.Substring(0, posInicial);
                leftOverString = leftOverString.Substring(posInicial + textInput.text.ToString().Length);
                cont++;

            } while (cont <=2);

            dialogOne.text += leftOverString;




        }
        catch (System.ArgumentOutOfRangeException ex)
        {
            //Debug.Log(ex);
        }

        TMP_Text texto = dialogOne;

        TMP_TextInfo textInfo = dialogOne.textInfo;

        //setando o texto invisivel
        if (dialogOne.maxVisibleCharacters != characterCounter)
        {
            dialogOne.maxVisibleCharacters = characterCounter;
        }

        if (characterCounter < textInfo.characterCount)
        {
            TMP_CharacterInfo charInfo = textInfo.characterInfo[characterCounter];
            if (charInfo.character == ' ')
            {
                characterCounter++;
            }
        }

        if (Time.time > timeCounter + characterCooldown)
        {
            timeCounter = Time.time;
            characterCounter++;
        }
        //if (characterCounter > dialogOne.text.Length)
        //{
        //    this.enabled = false;
        //}

    }

}
