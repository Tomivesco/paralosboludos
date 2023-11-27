using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alertadesactivada2 : MonoBehaviour
{
    public bool alertaon2 = false;
    // Start is called before the first frame update
    public float tiempocorriendo = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (alertaon2 == false)
        {
            OcultarMiObjeto();
        }

        if (alertaon2 == true)
        {
            tiempocorriendo += Time.deltaTime;
            MostrarMiObjeto();
            if (tiempocorriendo >= 5)
            {
                alertaon2 = false;
                tiempocorriendo = 0;

            }
        }
    }

    public void OcultarMiObjeto()
    {
        // Obt�n el componente Renderer del objeto actual
        Renderer miRenderer = GetComponent<Renderer>();

        // Verifica si el componente Renderer existe y est� habilitado
        if (miRenderer != null && miRenderer.enabled)
        {
            // Desactiva el renderizado del objeto
            miRenderer.enabled = false;
        }
    }
    public void MostrarMiObjeto()
    {
        // Obt�n el componente Renderer del objeto actual
        Renderer miRenderer = GetComponent<Renderer>();

        // Verifica si el componente Renderer existe y est� deshabilitado
        if (miRenderer != null && !miRenderer.enabled)
        {
            // Activa el renderizado del objeto
            miRenderer.enabled = true;
        }
    }
}