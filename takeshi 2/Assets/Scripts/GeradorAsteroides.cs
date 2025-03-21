using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorAsteroides : MonoBehaviour
{
    public GameObject AsteroidePrefab;
    public GameObject Asteroide2Prefab;
    public float temporizador;
    public Vector2 posMinima;
    public Vector2 posMaxima;

    void Update()
    {
        temporizador += Time.deltaTime;

        if (temporizador >= 2f)
        {
            Vector2 posAleatoria = new Vector2(Random.Range(posMinima.x, posMaxima.x), Random.Range(posMinima.y, posMaxima.y));
            Instantiate(AsteroidePrefab, posAleatoria, Quaternion.identity);
            temporizador = 0;

            Vector2 posAlea = new Vector2(Random.Range(posMinima.x, posMaxima.x), Random.Range(posMinima.y, posMaxima.y));
            Instantiate(Asteroide2Prefab, posAleatoria, Quaternion.identity);
            temporizador = 0;
        }
    }
}
