using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 velocidadRotacion ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}
