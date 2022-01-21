using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{

    [SerializeField] GameObject lamp;
    bool isCollided;
    bool isOn = false;

    //sprawdź czy jest kolizja
    void OnTriggerEnter(Collider other){
        //ustaw kolizje na tak
        isCollided = true;
        Debug.Log("collided");
    }
    //sprawdź czy opuścił kolizje
     void OnTriggerExit(Collider other){
         // ustaw kolizje na nie
         isCollided = false;
         Debug.Log("nie collided");
     }
    // Update is called once per frame
    void Update()
    {
        // sprawdź czy jest kolizja i wciśnięty klawisz E
        if(isCollided && Input.GetKeyDown(KeyCode.E)){
            // sprawdź czy lampa jest włączona
            if(isOn){
                Debug.Log("wyłączono śiwatło");
                // wyłącz lampę
                lamp.SetActive(false);
                // zmień zmienną
                isOn = false;
                return;
            }
            // sprawdź czy lampa jest wyłączona
            if(!isOn){
                Debug.Log("Włączono światło");
                // włącz lampę
                lamp.SetActive(true);
                // zmień zmienną
                isOn = true;
                return;
            }
        }
    }
    
}
