using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject player; 
   

    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0,gameObject.transform.position.y, player.gameObject.transform.position.z -10), Time.deltaTime * 100);
    }
}
