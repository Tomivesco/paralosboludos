using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alertadesactivada1 : MonoBehaviour
{
    public bool alertaon1 = false;
    // Start is called before the first frame update
    public float tiempocorriendo = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (alertaon1 == false)
        {
            OcultarMiObjeto();
        }

        if (alertaon1 == true)
        {
            tiempocorriendo += Time.deltaTime;
            MostrarMiObjeto();
            if (tiempocorriendo >= 5)
            {
                alertaon1 = false;
                tiempocorriendo = 0;

            }
        }
    }

    public void OcultarMiObjeto()
    {
        // Obtén el componente Renderer del objeto actual
        Renderer miRenderer = GetComponent<Renderer>();

        // Verifica si el componente Renderer existe y está habilitado
        if (miRenderer != null && miRenderer.enabled)
        {
            // Desactiva el renderizado del objeto
            miRenderer.enabled = false;
        }
    }
    public void MostrarMiObjeto()
    {
        // Obtén el componente Renderer del objeto actual
        Renderer miRenderer = GetComponent<Renderer>();

        // Verifica si el componente Renderer existe y está deshabilitado
        if (miRenderer != null && !miRenderer.enabled)
        {
            // Activa el renderizado del objeto
            miRenderer.enabled = true;
        }
    }
}