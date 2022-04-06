using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // biblioteca de UI

public class InterpretadorGeeks : MonoBehaviour
{

    // variável que guarda a carta que será interpretada
    public GeeksCard carta;

    // objetos na tela que vão desenhar as informações
    public Text nomeT, banidoT, orelhaT, effT, tamanhoT, twitT, NUT;

    // Start is called before the first frame update
    void Start()
    {
        MostrarCarta();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void TrocarCarta( GeeksCard _carta )
    {
        carta = _carta;
        MostrarCarta();
    }

    public void MostrarCarta()
    {
        // string pra string
        nomeT.text = carta.nome;
        effT.text = carta.efeito;

        // números pra string
        tamanhoT.text = carta.tamanho.ToString();
        twitT.text = carta.totalDeTwitteirosQueMeCancelaram.ToString();

        // operador ternário (if em uma linha)
        NUT.text = carta.odeiaNU ? "Odeia Now United" : "Gosta muito Now United";
        banidoT.text = carta.banidaNoYugi ? "Banidona" : "Pode usar";
        orelhaT.text = carta.temOrelhaBonita ? "Orelha top" : "Parece um cruzcredo";
        
    }

}
