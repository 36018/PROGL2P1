using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject Tower;
    private float scale;
    private Vector3 randPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*    float x = Random.Range(0, 5);
            float y = Random.Range(0, 5);
            float z = Random.Range(0, 5);*/
        


        if (Input.GetMouseButtonDown(0))
        {
            GameObject t = Instantiate(Tower);
            scale = Random.Range(0, 5);
            t.transform.localScale = new Vector3(scale, scale, scale);
            randPosition = new Vector3(Random.Range(-10, 10) ,0 , Random.Range(-10, 10));
            t.transform.position = randPosition;
        }

        
    }

    public class TowerSpawner
    {

    }

    //Transform rotation
        //transform.scale
}
