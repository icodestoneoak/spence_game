using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");

            foreach(GameObject door in doors)
            {
                door.GetComponent<UnlockDoor>().UpdateCoins();
            }

            Destroy(this.gameObject);
        }
    }
}
