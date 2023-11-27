using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreacionDeAlerta : MonoBehaviour
{
    public GameObject player; 
    public GameObject enemy; 
    public float alertDistance = 10.0f;
    public float enemySpeed = 5.0f;

    public Image alertImage; 

    void Update()
    {
        float distanceToEnemy = Vector3.Distance(player.transform.position, enemy.transform.position);
 
        Debug.Log("Distancia al enemigo: " + distanceToEnemy);

        if (distanceToEnemy <= alertDistance)
        {
            
            alertImage.enabled = true;
            Debug.Log("Mostrar alerta");
        }
        else
        {
            
            alertImage.enabled = false;
            Debug.Log("Ocultar alerta");
        }
    }
}
