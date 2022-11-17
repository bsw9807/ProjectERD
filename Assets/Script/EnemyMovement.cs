using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public Transform[] wayPointPos;
    [SerializeField]
    public float speed = 3.0f;
    int wayPointNum = 0;

    void Start()
    {
        transform.position = wayPointPos[wayPointNum].transform.position;
    }

    void Update()
    {
        
    }

    public void MovePath()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPointPos[wayPointNum].transform.position, speed * Time.deltaTime);
        if(transform.position == wayPointPos[wayPointNum].transform.position)
            wayPointNum++;
        if(wayPointNum == wayPointPos.Length)
            wayPointNum = 0;
    }
}
