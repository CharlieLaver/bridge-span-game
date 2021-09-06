using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    public float speed;
    private Transform targetObj3;
    private Vector3 target; 
 
    void Start()
    {
        targetObj3 = GameObject.Find("TargetObj3").transform;

        target = new Vector3(targetObj3.position.x, targetObj3.position.y);

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetObj3.position, speed * Time.deltaTime);

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
