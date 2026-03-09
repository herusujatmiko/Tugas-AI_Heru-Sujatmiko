using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public enum State
    {
        Idle,
        Chase,
        Attack
    }

    public State currentState;

    public Transform player;
    public float speed = 2f;
    public float chaseDistance = 5f;
    public float attackDistance = 2f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case State.Idle:
                if (distance < chaseDistance)
                {
                    currentState = State.Chase;
                }
                break;

            case State.Chase:
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    player.position,
                    speed * Time.deltaTime);

                if (distance < attackDistance)
                {
                    currentState = State.Attack;
                }
                break;

            case State.Attack:
                Debug.Log("Enemy Attack!!!");
                if(distance > attackDistance)
                {
                    currentState = State.Chase;
                }
                break;
        }
    }
}