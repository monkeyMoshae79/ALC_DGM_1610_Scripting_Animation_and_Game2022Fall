using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    //float is a data type with decimal numbers
    //Transform is captilized because 
    //currently empty containters 
    public float speed;
    public float stopDistance;
    public float retreatDistance;
    private Transform target;
    private float shotDelay;
    public float startDelay;
    
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance) //transform.position is starting point, and target.position is 
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //move toward target
        }

        else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position; //stay put
        }
        else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);//tunaway/run away
        }

        //Range attack
        if(shotDelay <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);// Fire Projectile
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;//Count down
        }
    }   
}
