using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RbManager
{

    // atributos
    Rigidbody rb;
    public float forca = 50f;
    public float velocidade = 200f;

    // métodos

    // construtor com parâmetros
    public RbManager( Rigidbody _rb )
    {
        rb = _rb;
    }

    public void Pulo()
    {
        Vector3 dir = Vector3.up * forca;
        rb.AddForce(dir, ForceMode.Force);
    }

    public void Mover( Vector2 _inputVector )
    {
        Vector3 dir = new Vector3( _inputVector.x, 0, _inputVector.y ) * velocidade;
        rb.AddForce(dir, ForceMode.Force);
    }


}
