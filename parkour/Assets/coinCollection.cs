using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinCollection : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Åö×²¼Ó·ÖÏú»Ù
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameController.instance.updateScore();
            
        }
    }
}
