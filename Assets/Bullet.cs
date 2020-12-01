using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 direction;
    Collider mycollider;
    
    public BulletStats bulletStats;
    public void Start()
    {
        Debug.Log("Shot Created");
        mycollider = GetComponent<Collider>();
    }
    private void Update()
    {
      
    }
    private void FixedUpdate()
    {

        transform.Translate(bulletStats.direction * bulletStats.Speed);
      
    }
    private void OnCollisionEnter(Collision collision)
    {
     
    }






}
