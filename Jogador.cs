using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Jogador : MonoBehaviour
{
    public TextMeshProUGUI vidaT;
    public TextMeshProUGUI PontosT;
    public TextMeshProUGUI MaiorPontosT;
    public float vel;
    public int vida = 99;
    public int pontos;
    public Rigidbody2D rb2d;
    private int contadorColisoes = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ExibirMaiorPontuacao();
    }

    void Update()
    {
        rb2d.velocity = new Vector2(vel * Input.GetAxisRaw("Horizontal"), vel * Input.GetAxisRaw("Vertical"));

        if (transform.position.x > 9.63f)
        {
            transform.position = new Vector2(-9.63f, transform.position.y);
        }
        if (transform.position.x < -9.63f)
        {
            transform.position = new Vector2(9.63f, transform.position.y);
        }
        if (transform.position.y > 4.82f)
        {
            transform.position = new Vector2(transform.position.x, -5.08f);
        }
        if (transform.position.y < -5.08f)
        {
            transform.position = new Vector2(transform.position.x, 4.82f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroide"))
        {
            contadorColisoes++;

            if (contadorColisoes >= 5)
            {
                FinalizarJogo();
                Destroy(this.gameObject);
            }
            vidaT.text = "Used Lifes: " + contadorColisoes.ToString();
        }
    }

    public void points()
    {
        pontos++;
        PontosT.text = "Points: " + pontos.ToString();
    }

    private void ExibirMaiorPontuacao()
    {
        int maiorPontos = PlayerPrefs.GetInt("MaiorPontos", 0);
        MaiorPontosT.text = "High Score: " + maiorPontos.ToString();
    }

    private void FinalizarJogo()
    {
        int maiorPontos = PlayerPrefs.GetInt("MaiorPontos", 0);

        if (pontos > maiorPontos)
        {
            PlayerPrefs.SetInt("MaiorPontos", pontos);
            ExibirMaiorPontuacao();
        }
    }
}
