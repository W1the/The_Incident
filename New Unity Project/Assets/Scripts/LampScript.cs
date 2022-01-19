using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{

    [SerializeField] GameObject lamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        lamp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
