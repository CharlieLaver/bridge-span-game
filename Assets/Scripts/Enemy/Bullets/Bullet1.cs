using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public float speed;
    private Transform targetObj1;
    private Vector3 target; 
 
    void Start()
    {
        targetObj1 = GameObject.Find("TargetObj1").transform;

        target = new Vector3(targetObj1.position.x, targetObj1.position.y);

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetObj1.position, speed * Time.deltaTime);

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
