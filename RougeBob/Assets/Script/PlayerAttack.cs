using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        private float attackDelay;
        public flaot startDelay;
        public Transform attackPos;
        public LayerMask whatIsEmemies;
        public float attackRange;
        public int damage;
    }

    // Update is called once per frame
    void Update()
    {
        if(attackDelay <= 0 )
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEmemies); //list of enemis going to hurt (List how far we attack, where to attack, and who to attack) (Who we fight)

                for(int i = 0; i < enemiesToDamage.Length; i++) //(starting point; how many time going loop/loop duriations, [++ = increased by one] how going increased until reach loop duration and get out of loop)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damge);
                }
            }
           
             
        }
    }
  
  void OnDrawGizmosSelected(
[]  
}


