using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioSimulacion : MonoBehaviour
{
    public Button BtnIniciarSimulacion;
    public Button BtnRestartEscenaDomino;
    public Button BtnAbrirSegundaSimulacion;

    public Image ImgDegradeNegroPreSimulacion;

    void Start()
    {
        Time.timeScale = 0f; // HABIA QUE PONERLO AL COMIENZO DEL Start, SI NO, LA ESCENA ARRANCABA DIRECTO

        ImgDegradeNegroPreSimulacion = GetComponent<Image>();

        BtnIniciarSimulacion = GetComponent<Button>();
        BtnRestartEscenaDomino = GetComponent<Button>();
        BtnAbrirSegundaSimulacion = GetComponent<Button>();

        BtnRestartEscenaDomino.enabled = false;
        BtnAbrirSegundaSimulacion.enabled = false;

        
    }

    
    void Update()
    {
        
    }

    public void IniciarSimulacion()
    {
        Time.timeScale = 1f;

        Destroy(ImgDegradeNegroPreSimulacion);
        Destroy(BtnIniciarSimulacion);

        BtnRestartEscenaDomino.enabled = true;
        BtnAbrirSegundaSimulacion.enabled = true;

        
    }
}
