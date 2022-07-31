using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour

{
    
    public GameObject Wave;
    public bool canShoot = true;
    public float cooldown = 2f;
  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        { Shoot();
           
        }
      //  if (Input.GetKeyDown(KeyCode.J))
        //{
          //  Burst();
       // }
       // if (Input.GetKeyDown(KeyCode.K))
        //{
          //  BurstTwo();
       // }
        //if (Input.GetKeyDown(KeyCode.L))
       // {
        //    BurstTree();
            
        //}
    }

    private void Shoot()
    {

        if (canShoot)
        {
            canShoot = false;
            Instantiate(Wave, transform);
            Invoke("ResetShoot", cooldown);


        }
    }


  //  private void Burst() 
    //{ 

      //  if (canShoot)
        //{
          //  canShoot = false;
            //Invoke("Shooting", 0.5f);
           // Instantiate(Wave, transform);
           // Invoke("ResetShoot", cooldown);


        //}
    //}
   // private void BurstTwo()
    //{

      //  if (canShoot)
        //{
          //  canShoot = false;
            //Invoke("Shooting", 0.5f);
            //Invoke("Shooting", 1f);
           // Instantiate(Wave, transform);
           // Invoke("ResetShoot", cooldown);


///        }
   // }

    //private void BurstTree()
    //{

      //  if (canShoot)
       // {
         //   canShoot = false;
           // Invoke("Shooting", 0.5f);
          //  Invoke("Shooting", 1f);
          //  Invoke("Shooting", 1.5f);
          //  Instantiate(Wave, transform);
          //  Invoke("ResetShoot", cooldown);


       // }
   // }
    private void ResetShoot()
    {
        canShoot = true;
    }
     
    private void Shooting()
    {
        Instantiate(Wave, transform);
    }
}
    
