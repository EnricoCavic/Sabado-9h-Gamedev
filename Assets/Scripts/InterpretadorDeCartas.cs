using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterpretadorDeCartas : MonoBehaviour
{

    public GeeksCard carta;
    SpriteRenderer renderizador;

    public Text nome, atq, def, hp, custo, crit, vel, eff;

    // Start is called before the first frame update
    void Start()
    {
        renderizador = GetComponent<SpriteRenderer>();
        MostrarCarta(carta);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void MostrarCarta( GeeksCard _carta )
    {
        carta = _carta;
        
        nome.text = carta.name;
        atq.text = carta.ataque.ToString();
        def.text = carta.defesa.ToString();
        hp.text = "Vida: " + carta.vida.ToString();
        custo.text = "Custo: " + carta.custo.ToString();
        crit.text = "Crítico: " + carta.critico.ToString();
        vel.text = "Velocidade: " + carta.velocidade.ToString();
        eff.text = carta.efeito.ToString();
    }

}
