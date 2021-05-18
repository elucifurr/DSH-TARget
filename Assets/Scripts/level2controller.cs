using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level2controller : MonoBehaviour
{
    private int dianas;
    public Text texto;

    void Start()
    {
        dianas = 7;
        texto.text = "Dianas: " + dianas;
    }

    void Update()
    {
        if (dianas != 0){
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if(Physics.Raycast(ray, out Hit)){
                    Destroy(Hit.transform.gameObject);
                    dianas--;
                    texto.text = "Dianas: " + dianas;
                }
            }
        }
        else{
            SceneManager.LoadScene("Fin");
        }
    }
}
