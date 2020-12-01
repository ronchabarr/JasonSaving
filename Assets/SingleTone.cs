using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone : MonoBehaviour
{
    
    TowerController towerController;
    public GameObject enemy;
    public GameObject tower;
    public GameObject Ammo;
    public float points;
    


    public Transform[] SpawnLocations;

    
    public float mouse_Sensetivity;

    
    Bullet _bullet;
    private void Start()
    {
        towerController = tower.GetComponent<TowerController>();
        _bullet = Ammo.GetComponent<Bullet>();


    }
    public void EnemyDied()
    {
        Debug.Log("Enemy Died Adding Points");
        points++;
    }
    public void Update()
    {
       InputForm inputForm = towerController.GetInputForm();

        if (inputForm.shoot)
        {
            Debug.Log("Space Clicked-Shoot Activated");
          GameObject bullet= Instantiate(Ammo,tower.transform.position,tower.transform.rotation);
            Destroy(bullet, 2);
            
        }
       
        tower.transform.Rotate(inputForm.rotVector*mouse_Sensetivity);

        
        
        
        
    }
}
public class InputForm
{
    public Vector3 rotVector;
    public bool shoot;



}
public class EnemyAdmin
{
    public float hp;
    public float Maxhp;
}
