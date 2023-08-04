using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public int maxCoins = 1;

    private int coinsCollected = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coinsCollected == maxCoins)
        {
            Destroy(this.gameObject);
        }
    }

    public void UpdateCoins()
    {
        coinsCollected++;
    }
}
