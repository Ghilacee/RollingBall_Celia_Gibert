using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update
    float Velocidad = 3.0f;
    [SerializeField] Vector3 dirccion;
    float Timer = 0;
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(dirccion.normalized * Velocidad * Time.deltaTime);
        Timer += Time.deltaTime;
        if (Timer >= 5)
        {
            dirccion = -dirccion;

            Timer = 0;
        }

    }
    
}
