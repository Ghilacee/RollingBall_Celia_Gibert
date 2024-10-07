using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float fuerza = 20f;
    [SerializeField] float direccion = 20f;
    [SerializeField] Vector3 movimiento;
   
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce( movimiento* fuerza, ForceMode.Impulse);

        }
       
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        float moveVertical = Input.GetAxisRaw("Vertical"); 
        rb.AddForce(new Vector3(moveHorizontal, 0,moveVertical).normalized * fuerza , ForceMode.Force);


      //rb.AddForce ( Vector3 * fuerza,  ForceMode.TipoF );



    }
}

