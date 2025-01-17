using UnityEngine;
using static Unit;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public Transform[] waypoints;
    private Vector3 targetposition = Vector3.zero;
    [SerializeField]
    private int waypointIndex = 0;
    public GameObject enemy;
    [SerializeField]
    protected float speed = 2f;
    [SerializeField]
    protected float maxHealth = 200;

    private float currentHealth;

    public int Health { get; }

    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject;
        targetposition = waypoints[0].position;

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
  

    public virtual void Move()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, step);

        if (Vector3.Distance(transform.position, waypoints[waypointIndex].position) < .1f && waypointIndex < waypoints.Length - 1)
        {
            waypointIndex++;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hit")
        {
            float damage = other.gameObject.GetComponent<MoveProj>().damage;
            TakeDamage(damage);
        }
    }
}
