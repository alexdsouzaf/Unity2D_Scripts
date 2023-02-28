using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text pontosTexto;

    int pontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (pontosTexto != null)
            pontosTexto.text = pontos.ToString() + " PONTOS";
    }

    // Update is called once per frame
    void Update()
    {
        pontos++;
        if (pontosTexto != null)
            pontosTexto.text = pontos.ToString() + " PONTOS";
        

    }
}
