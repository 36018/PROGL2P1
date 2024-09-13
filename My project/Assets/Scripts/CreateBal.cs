using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBal : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;

    private float elapsedTime = 0f;

    private Vector3 randPosition;
    // Start is called before the first frame update
    void Start()
    {
        //100 ballen

        for (int i = 0; i < 100; i++)
        {
            Color color = Randomcolor();
            Vector3 randPos = Randomposition();
            CreateBall(color, randPos);
        }
    }

    void Update()
    {
        
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
           GameObject B = CreateBall(Randomcolor(), Randomposition());
            elapsedTime = 0f;
            DestroyBall(B);
        }
        
        

    }

    private GameObject CreateBall(Color c, Vector3 randPosition)
    {
        GameObject ball = Instantiate(prefab);
        Material mat = ball.GetComponent<MeshRenderer>().material;
        
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        //GameObject t = Instantiate(Tower);
        
        ball.transform.position = randPosition;

        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3);
    }

    private Color Randomcolor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        return randColor;
    }

    private Vector3 Randomposition()
    {
        randPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

        return randPosition;
    }
}
