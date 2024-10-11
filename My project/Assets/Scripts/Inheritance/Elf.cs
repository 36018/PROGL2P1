using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer renderer;
    private float elapsedTime = 0f;
    private bool visible = true;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
        maxHealth = 100;

        renderer = GetComponent<Renderer>();
    }
    private void Update()
    {
        ToggleVisibility();
        Move();
    }

    private void ToggleVisibility()
    {

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 3 && renderer.enabled)
        {
            //Invisible
            renderer.enabled = false;
            elapsedTime = 0f;
        }

        if (elapsedTime > 0.5 && !renderer.enabled)
        {
            //Visible
            renderer.enabled = true;
            elapsedTime = 0f;
        }
        
       

        
    }
}
