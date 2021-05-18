using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public Button btn1;
    private bool pulsado1;
    void Start()
    {
        btn1.onClick.AddListener(Pulsar1);

    }
    void Update(){}
    void FixedUpdate(){
        if(pulsado1){
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
    void Pulsar1(){
        pulsado1 = true;
    }
}
