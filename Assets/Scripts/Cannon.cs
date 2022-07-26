using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour

{
    
    public GameObject Wave;
        public bool canShoot = true;
  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;
        shoot();               
    }
    private void shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(Wave, transform);
            Invoke("ResetShoot", 1f);
         

        }
        
    }
    private void ResetShoot()
    {
        canShoot = true;
    }
     
}
