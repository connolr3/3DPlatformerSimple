using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{   
      [SerializeField] GameObject [] EndPoints;
      int CurrentEndPointIndex = 0;
      [SerializeField] float speed = 1f;
    void Update()
    {
        if(Vector3.Distance(transform.position,EndPoints[CurrentEndPointIndex].transform.position )<0.1f){
        CurrentEndPointIndex++;
        if(CurrentEndPointIndex>=EndPoints.Length){
            CurrentEndPointIndex=0;
        }
        }
      //transform refers to transform component
        transform.position = Vector3.MoveTowards(transform.position,EndPoints[CurrentEndPointIndex].transform.position,speed*Time.deltaTime);
    }
}
