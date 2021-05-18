using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button btn1, btn2, btn3;
    private bool pulsado1, pulsado2, pulsado3;
    void Start()
    {
        btn1.onClick.AddListener(Pulsar1);
        btn2.onClick.AddListener(Pulsar2);
        btn3.onClick.AddListener(Pulsar3);
    }
    void Update(){}
    void FixedUpdate(){
        if(pulsado1){
            SceneManager.LoadScene("nivel1", LoadSceneMode.Single);
        }
        if(pulsado2){
            SceneManager.LoadScene("nivel2", LoadSceneMode.Single);
        }
        if(pulsado3){
            SceneManager.LoadScene("nivel3", LoadSceneMode.Single);
        }
    }
    void Pulsar1(){
        pulsado1 = true;
    }
    void Pulsar2(){
        pulsado2 = true;
    }
    void Pulsar3(){
        pulsado3 = true;
    }
}
