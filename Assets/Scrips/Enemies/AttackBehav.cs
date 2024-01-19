using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackBehav : StateMachineBehaviour
{
    Transform player;
    Transform monster;

    float chaseRange = 2.8f;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        monster = GameObject.FindGameObjectWithTag("monster").transform;
        //DragonAudioManager.instance.Play("DragonAttack"); //Sesleri bu şekilde ekleyebilirsin

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        Health.Damage(1f);
        Vector3 targetPosition = new Vector3(player.position.x, monster.position.y, player.position.z);
        animator.transform.LookAt(targetPosition);
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance > chaseRange)
        {
            //animator.transform.position.x = 0;
            //Buradya de active oldugunda saldırmama koyayacgız.
            animator.SetBool("isAttacking", false);
            //DragonAudioManager.instance.Stop("DragonAttack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
