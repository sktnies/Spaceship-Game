using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bala : MonoBehaviour
{
    public GameObject Player;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Jogador");
        Destroy(this.gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*Time.deltaTime*vel);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Asteroide"))
        {
            Player.GetComponent<Jogador>().points();    
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
