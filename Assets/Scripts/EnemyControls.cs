using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    
    [SerializeField] private float health = 100;
    [SerializeField] private bool isMoving = false;

    private Rigidbody2D enemyRigidBody;

    private Animator enemyAnimator;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyRigidBody = GetComponent<Rigidbody2D>();

        //If we set to isMoving then the Enemy moves back and forth.
        //Otherwise it is idle.
        if(isMoving == true)
        {
            enemyAnimator.SetInteger("EnemyAnimstate", 1);
        }
    }       

    //Take damage from the player sword slashes.
    public void TakeDamage(float damage)
    {
        health -= damage;        

        if(health <= 0)
        {
            //Debug.Log("Enemy died");
            Destroy(gameObject);
        }
    }
}
