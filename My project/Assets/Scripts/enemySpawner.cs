using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject enemy;

    private float elapsedTime = 0f;

    private List<GameObject> enemies= new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Gebruik de Add methode om je enemies aan de lijst toe te voegen.
        
        //Gebruik Instantiate om je enemies te creeren.
        GameObject vijand = Instantiate(enemy);
        enemies.Add(vijand);
        //Gebruik de Clear methode om je lijst te legen.
        enemies.Clear();
        //Gebruik Destroy om je enemies te verwijderen.
        Destroy(vijand);


        //Laat de EnemySpawner in 1 keer 100 enemies spawnen als je op "W" - toets drukt.
        for (int i = 0; i < 100; i++)
        {
            if (Input.GetKey(KeyCode.W))
            {
                print("Spawn my minions");
                Instantiate(enemy);
            }
        }
        //Laat de EnemySpawner elke seconde 3 enemies spawnen.


        elapsedTime += Time.deltaTime;

        if (elapsedTime > 3f)
        {
            Instantiate(enemy);
            elapsedTime = 0f;
        }


        if (Input.GetKey(KeyCode.Q))
        {
            print("Go away my minions");
            GameObject[] vijanden = GameObject.FindGameObjectsWithTag("delete");
            foreach (GameObject delete in vijanden)
            {
                Destroy(delete);
            }
        }
        

        //Laat de EnemySpawner alle enemies verwijderen als je op de "Q" - toets drukt.

    }

  
}
