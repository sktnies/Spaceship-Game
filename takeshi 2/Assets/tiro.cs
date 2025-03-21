using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public TextMeshProUGUI PontosT;
    public float velocidadeBala;
    public Vector2 direcao;
    private int pontos = 0;
    private int contadorcolisoes = 0;

    void Start()
    {
        if (direcao == Vector2.zero)
        {
            direcao = Vector2.up;
        }

        Destroy(this.gameObject, 5f);
    }

    void Update()
    {
        transform.Translate(direcao * Time.deltaTime * velocidadeBala);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroide"))
        {

            pontos++; 
            PontosT.text = pontos.ToString();

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}


