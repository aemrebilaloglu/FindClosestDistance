using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosestDistance : MonoBehaviour
{
    //Enemy.enemyList = GameObject List in Enemy script. 
    public GameObject closest;

    private void Update()
    {
        FindClosest();
    }
    private void FindClosest()
    {
        if (closest != null) return;
        float minDistance = Mathf.Infinity;
        for (int i = 0; i < Enemy.enemyList.Count; i++)
        {
            float distance = Vector3.Distance(transform.position, Enemy.enemyList[i].transform.position);
            if (distance < minDistance)
            {
                closest = Enemy.enemyList[i];
                minDistance = distance;
            }
        }
    }
}
