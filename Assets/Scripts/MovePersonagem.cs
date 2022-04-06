// bilbliotecas/libs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    // toda classe possui variaveis e funções/métodos

    InputManager meuInput;

    // mostra as vars na unity mas as mantém privadas
    [SerializeField] RbManager meuRb;

@
    // ocorre uma vez quando inicia o projeto
    void Start()
    {
        meuInput = new InputManager2();
        meuRb = new RbManager( GetComponent<Rigidbody>() );
    }

    // ocorre uma vez por frame
    void Update()
    {
        meuInput.RegistrarInputs();
    }

    // sempre acontece 50 vezes por segundo
    void FixedUpdate()
    {
        if( meuInput.jump )
        {
            meuRb.Pulo();
        }

        meuRb.Mover( meuInput.inputVector );

    }

}
