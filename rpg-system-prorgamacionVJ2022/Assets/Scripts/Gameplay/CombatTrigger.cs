using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            FindObjectOfType<Combat>().SetupBattle();
            
            //Debug.Log("OH MY GOD");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
