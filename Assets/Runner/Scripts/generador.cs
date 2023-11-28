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
    public float tiempocorriendo = 0;
    public alertadesactivada a;
    public alertadesactivada1 b;
    public alertadesactivada2 c;
    public MovimientoEnemigo d;
    public float tiempocorriendo1 = 0;


    void Start()
    {
        tiempoUltimaGeneracion = Time.time;
        a = FindObjectOfType<alertadesactivada>();
        b = FindObjectOfType<alertadesactivada1>();
        c = FindObjectOfType<alertadesactivada2>();
        d = FindObjectOfType<MovimientoEnemigo>();
    }

    void Update()

    {
        tiempocorriendo1 = Time.time;

        if (Time.time - tiempoUltimaGeneracion > tiempoEntreGeneracion)
        {
            GenerarEnemigo();
            tiempoUltimaGeneracion = Time.time;

        }

        aumentoVelocidad();
    }

    void GenerarEnemigo()
    {

        int carrilAleatorio = Random.Range(0, carriles.Length);
        Vector3 posicionGeneracion = carriles[carrilAleatorio].position;
        Quaternion rotacion = Quaternion.identity;

        if (carrilAleatorio == 0)
        {

            a.alertaon = true;
            rotacion = Quaternion.Euler(0, 0, rotacionXEnCarril0);

        }
        else if (carrilAleatorio == 2)
        {
            c.alertaon2 = true;
            rotacion = Quaternion.Euler(0, 0, rotacionZEnCarril2);
        }
        if (carrilAleatorio == 1)
        {
            b.alertaon1 = true;
        }

        Instantiate(enemigoPrefab, posicionGeneracion, rotacion);
    }

    void aumentoVelocidad()
    {
        if (tiempocorriendo1 >= 10)
        {
            d.velocidad = 80;
        }
    }
}