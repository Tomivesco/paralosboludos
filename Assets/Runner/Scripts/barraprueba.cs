using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class barraprueba : MonoBehaviour
{ 
    public Slider progressBar;
    public float tiempoTotal = 5f; // Tiempo total en segundos

    private void Start()
    {
        // Llama a la funci�n para iniciar la barra de progreso
        IniciarProgreso();
    }

    private void IniciarProgreso()
    {
        // Resetea el valor de la barra de progreso al inicio
        progressBar.value = 0;

        // Llama a la funci�n de actualizaci�n de la barra de progreso
        InvokeRepeating("ActualizarProgreso", 0, tiempoTotal / 100);
    }

    private void ActualizarProgreso()
    {
        // Incrementa el valor de la barra de progreso
        progressBar.value++;

        // Si la barra de progreso alcanza el valor m�ximo, det�n la actualizaci�n
        if (progressBar.value >= progressBar.maxValue)
        {
            CancelInvoke("ActualizarProgreso");
        }
    }
}












