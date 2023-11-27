using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Transform[] carriles;
    public float tiempoEntreGeneracion = 2.0f;
    public float rotacionXEnCarril0 = -30; // Ajusta el valor según tus necesidades
    public float rotacionZEnCarril2 = 25;
    private float tiempoUltimaGeneracion;

    void Start()
    {
        tiempoUltimaGeneracion = Time.time;
    }

    void Update()
    {
        if (Time.time - tiempoUltimaGeneracion > tiempoEntreGeneracion)
        {
            GenerarEnemigo();
            tiempoUltimaGeneracion = Time.time;
        }
    }

    void GenerarEnemigo()
    {
        int carrilAleatorio = Random.Range(0, carriles.Length);
        Vector3 posicionGeneracion = carriles[carrilAleatorio].position;
        Quaternion rotacion = Quaternion.identity;

        if (carrilAleatorio == 0)
        {
            rotacion = Quaternion.Euler(0, 0, rotacionXEnCarril0);
        }
        else if (carrilAleatorio == 2)
        {
            rotacion = Quaternion.Euler(0, 0, rotacionZEnCarril2);
        }

        Instantiate(enemigoPrefab, posicionGeneracion, rotacion);
    }
}

