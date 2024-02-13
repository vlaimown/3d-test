using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    //public void Death()
    //{
    //    Destroy(gameObject);
    //}
}
