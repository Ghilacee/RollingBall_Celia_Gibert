using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float fuerza = 20f;
    [SerializeField] float direccion = 20f;
    [SerializeField] Vector3 movimiento;
    float moveHorizontal;
    float moveVertical;
    [SerializeField] int puntos = 0;
    [SerializeField] private float distanciaRaycast;


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

        moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        moveVertical = Input.GetAxisRaw("Vertical"); 
        //rb.AddForce(new Vector3(moveHorizontal, 0,moveVertical).normalized * fuerza , ForceMode.Force);


   



    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(moveHorizontal, 0, moveVertical).normalized * fuerza, ForceMode.Force);


    }
    private bool DetectarSuelo()
    {
       bool resultado =  Physics.Raycast(transform.position, Vector3.down , distanciaRaycast);
       Debug.DrawRay(transform.position, Vector3.down, Color.red, 2f);
       return resultado; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            puntos += 10;

        }

    }
}

