using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Transform targetObj;
    private Vector3 target; 

    
 
    void Start()
    {
        targetObj = GameObject.Find("TargetObj").transform;

        target = new Vector3(targetObj.position.x, targetObj.position.y);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetObj.position, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter(Collider other)
    {
       DestroyProjectile();

    }

    void DestroyProjectile()
        {
           Destroy(this.gameObject);
        }
}
