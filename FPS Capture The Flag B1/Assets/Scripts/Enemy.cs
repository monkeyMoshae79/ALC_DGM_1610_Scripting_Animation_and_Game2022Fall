using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
using System.Linq;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int curHP;
    public int maxHP;
    public int scoreToGive;

    [Header("Movement")]
    public float moveSpeed;
    public float attackRange;

    [Header("Path Info")]
    public float yPathOffset;
    private List<Vector3> path;
    //private Weapon weapon;
    private GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        curHP = maxHP;

        //Gather the Components
        //Weapon = GetComponent<Weapon>();
        target = FindObjectOfType<FPScontorler>().gameObject;

        InvokeRepeating("UpdatePath", 0.0f, 0.5f);
    }

    void UpdatePath()
    {
        // Calculate a path to the target
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);
                                // orIgin           //distenation/target/player  //Area Emeny can move in //establish the path it will take

        // Save path as a list
        path = navMeshPath.corners.ToList();
    }

    void ChaseTarget()
    {
        if(path.Count == 0)
            return;

        //move towards th closest path
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0, yPathOffset, 0), moveSpeed * Time.deltaTime);

        if(transform.position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage; //Subtracts damage amount from health

        if(curHP <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Look at Target
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

        transform.eulerAngles = Vector3.up * angle;

        // Get distance from enemy to player/trager
        float dist = Vector3.Distance(transform.position, target.transform.position);

        if(dist <= attackRange)
        {
            //*
            //if(weapon.FanShoot())
            //weap.Shot();
            //*
        }
        else
        {
            ChaseTarget();
        }
    }
}
