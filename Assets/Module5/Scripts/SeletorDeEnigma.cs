using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Dificuldade dropdown;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botao1Texto;
    [SerializeField] Text botao2Texto;
    [SerializeField] Text botao3Texto;
    [SerializeField] Text botao4Texto;
    [SerializeField] Text scoreTexto;
    [SerializeField] Text recordTexto;
    List<string> repostasPossiveis = new List<string>();
    int score;
    int record;
    int index;
    int indexRespostas;
    int dificuldade;
    

    void Start()
    {
        scoreTexto.text = "Score: " + score.ToString();
        //pegar a variavel armazenada no pc e setar o valor no record / case null
        record = PlayerPrefs.GetInt("record", 0);
        recordTexto.text = "Record: " + record.ToString();

        //pegar a variavel dificuldade do dropdown
        dificuldade = dropdown.dificuldade;

        //Fun��o para selecionar a dificuldade
        List<Enigma> listaTemp = Dificuldade();

        //Fun��o para inserir as questoes na tela, conforme a dificuldade
        QuestoesAleatorias(listaTemp);


    }

    //Fun��o para retornar a dificuldade das questoes
    public List<Enigma> Dificuldade()
    {
        //setar dificuldade
        switch (dificuldade)
        {
            case 1:
                Debug.Log("Easy");
                return lista.listaDeEnigmas;
                break;
            case 2:
                Debug.Log("Medium");
                return lista.listaDeEnigmasMedio;
                break;
            case 3:
                Debug.Log("Hard");
                return lista.listaDeEnigmasDificil;
                break;
        }
        return lista.listaDeEnigmas;
    }

    public void QuestoesAleatorias(List<Enigma> lista)
    {
        //aleatorio para posi��o das questoes
        index = Random.Range(0, lista.Count);

        //add na lista de repostas possiveis
        //adicionar na lista as questoes
        repostasPossiveis.Add(lista[index].repostaCorreta);
        repostasPossiveis.Add(lista[index].repostaErrada1);
        repostasPossiveis.Add(lista[index].repostaErrada2);
        repostasPossiveis.Add(lista[index].repostaErrada3);

        //=======================================================

        //aleatorio para inserir os textos nos botoes
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        //inserindo os textos nos botoes
        perguntaTexto.text = lista[index].pergunta;

        botao1Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao2Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao3Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao4Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);

    }

    public void Score()
    {
        //verifica a dificuldade e soma o valor do score
        switch (dificuldade)
        {
            case 1:
                score = score + 5;
                break;
            case 2:
                score = score + 10;
                break;
            case 3:
                score = score + 15;
                break;
        }

        //insere o texto na tela
        scoreTexto.text = "Score: " + score.ToString();

        //verifica se o score � maior que o record e atualiza
        if (score > record)
        {
            record = score;
            recordTexto.text = "Record: " + record.ToString();
            //salvar um valor no texto record - cache do pc
            PlayerPrefs.SetInt("record", record);
        }
        
    }

    public void OnClick(Text TextoBotao)
    {
        List<Enigma> listaTemp = Dificuldade();

        if (TextoBotao.text == listaTemp[index].repostaCorreta)
        {
            //remove a questao da lista quando acerta
            listaTemp.Remove(listaTemp[index]);
            Score();
            Start();
        }
        else
        {
            //Resetar a cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}