using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    // atributos (variável)
    public bool jump { get; private set; }
    public Vector2 inputVector = new Vector2();

    // métodos (função)
    public void RegistrarInputs()
    {
        jump = Input.GetKeyDown(KeyCode.Space);
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }

}


