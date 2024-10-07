using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public Transform player;
    private Vector2 movement;
    private Rigidbody2D rb;
    public Animator animator;
    public static int enemiesKilled = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            animator.SetBool("Collided", true);
            Destroy(gameObject, 0.8f);
            enemiesKilled++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        animator.SetInteger("XDirection", Direction());
        
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        if((player.position.x - rb.position.x) < 11 && (player.position.y - rb.position.y) < 6)
        {
            rb.MovePosition((Vector2)transform.position + (direction * 0.5f * Time.deltaTime));
        }
        
    }
    private int Direction()
    {
        if(player.transform.position.x > transform.position.x)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}
