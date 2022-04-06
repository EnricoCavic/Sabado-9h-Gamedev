using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Card", menuName = "ScriptableObj/GeeksCard")]
public class GeeksCard : ScriptableObject // herança
{
    public long ataque = 0;
    public long defesa = 0;
    public long vida = 0;
    public long custo = 0;
    public long critico = 0;
    public long velocidade = 0;
    public string efeito = "";
}
