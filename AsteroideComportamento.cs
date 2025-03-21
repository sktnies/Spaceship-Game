using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideComportamento : MonoBehaviour
{
    public float velocidadeAsteroide;
    public Vector2 direcaoMovimento;

    void Start()
    {
        direcaoMovimento = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        this.transform.localScale = Vector3.one * 10;
        transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
    }

    void Update()
    {
        transform.Translate(direcaoMovimento * velocidadeAsteroide * Time.deltaTime);

        if (transform.position.x < -8f || transform.position.x > 8f || transform.position.y < -4f || transform.position.y > 4f)
        {
            transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
           
            Destroy(this.gameObject);
        }
    }
}

