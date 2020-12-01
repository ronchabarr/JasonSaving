using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp;
    Rigidbody rb;
    public SingleTone singleTone;
    public BasicEnemy basicEnemy;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        hp = basicEnemy.maxHp;
        rb.AddExplosionForce(10, transform.position, 0.01f);
    }
    private void Update()
    {
        if (DeathByFall())
        {

            
            
            singleTone.EnemyDied();
            Debug.Log(singleTone.points);
            Destroy(this.gameObject);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Enemy Got Hit!");
            rb.AddExplosionForce(1000, collision.transform.position, 0.1f);

            Destroy(collision.gameObject);
            hp -= 10;
            if (DeathByShoot())
            {
                Debug.Log("Died From Hit - Duplicating");
                Instantiate(this.gameObject);
                Instantiate(this.gameObject);
               
                Destroy(this.gameObject);
            }
        }
    }
    public bool DeathByFall()
    {
        
        if (transform.position.y <= -5)
        {
            
            return true;
        }

         return false;

    }
    public bool DeathByShoot()
    {
        if (hp <= 0)
        {
            return true;
        }
            return false;
    }

}
