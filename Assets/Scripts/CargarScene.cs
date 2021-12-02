using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargarScene : MonoBehaviour
{
    //public Button btnAbrirPantallaCreds;

    //public TransDeEscns tomarMetodoTransicionarEntreEscenas;
           

    /*private void Start()
    {
        tomarMetodoTransicionarEntreEscenas = GetComponent<TransDeEscns>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CargaScene();
        }
    }

    public void CargaScene()
    {
        tomarMetodoTransicionarEntreEscenas.TransicionarEntreEscenas();
    }*/

    public void CargaScene(string nombreEscenaDeJuego)
    {
       SceneManager.LoadScene(nombreEscenaDeJuego);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
    
}
