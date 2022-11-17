using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLoot : MonoBehaviour
{
    private GameManager gm;
    public float chestDelay = 0.5f;

    public ItemDrop iT;

    //public float prefab;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        iT = GameObject.Find("HealthAdded").GetComponent<ItemDrop>();
    }

    // Update is called once per frame
    void Update()
    {}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject, chestDelay);
            gm.key --;
            Debug.Log("Chest is open");
            //Instantiate(, Quaternion.identity);
        }
        else
        {
            Debug.Log("Chest is locked. You need a key");
        }
    }
}
