using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackDelay;
    public float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        if(attackDelay <= 0 )
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies); //list of enemis going to hurt (List how far we attack, where to attack, and who to attack) (Who we fight)

                for(int i = 0; i < enemiesToDamage.Length; i++) //(starting point; how many time going loop/loop duriations, [++ = increased by one] how going increased until reach loop duration and get out of loop)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                }
            }
           
             attackDelay = startDelay;
        }
        else 
        {
            attackDelay -= Time.deltaTime;
        }
    }
   

  void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(attackPos.position, attackRange);
  }
}


