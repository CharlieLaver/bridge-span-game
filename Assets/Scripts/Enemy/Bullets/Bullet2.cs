using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed;
    private Transform targetObj2;
    private Vector3 target; 
 
    void Start()
    {
        targetObj2 = GameObject.Find("TargetObj2").transform;

        target = new Vector3(targetObj2.position.x, targetObj2.position.y);

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetObj2.position, speed * Time.deltaTime);

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
