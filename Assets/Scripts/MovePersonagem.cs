// bibliotecas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// começa a nossa classe
public class MovePersonagem : MonoBehaviour
{
    string mensagem;

    // int, char, string, boolean

    public Vector2 inputVector; 

    bool jumpInput;

    Rigidbody meuRb;
    public float velocidade;
    public float forcaPulo;
    

    // é uma função que ira ocorrer no inicio do jogo
    void Start()
    {
        inputVector = new Vector2();
        meuRb = GetComponent<Rigidbody>();

        mensagem = "Agora esta rodando o Start()";
        Debug.Log( mensagem );
        // tudo aqui esta dentro do start
    }

    // é uma função que irá ocorrer uma vez por frame (fps)
    // game loop
    void Update()
    {       
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        jumpInput = Input.GetKeyDown(KeyCode.Space);

        mensagem = "Agora estamos dentro do Update()";
        Debug.Log( mensagem );
    
        // tudo escrito aqui ocorre em média 30x por segundo
    }

    // sempre ocorre 50 vezes por segundo
    void FixedUpdate() 
    {
        // movimento
        Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y) * velocidade;
        meuRb.AddForce(dir, ForceMode.Force);

        // pulo
        if(jumpInput == true)
        {
            Vector3 cima = Vector3.up * forcaPulo;
            meuRb.AddForce(cima, ForceMode.Impulse);
        }

    }

}
