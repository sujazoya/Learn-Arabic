using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] lettersToSpawwn;

    public float spawnLimitXLeft = -22;
    public float spawnLimitXRight = 7;
    public float spawnPosY = 0;

  //Spawn this object
     public GameObject spawnObject;
 
     public float maxTime = 5;
     public float minTime = 2;
 
     //current time
     private float time;
 
     //The time to spawn the object
     private float spawnTime;
 
     void Start(){
         SetRandomTime();
         time = minTime;
     }
 
     void FixedUpdate(){
 
         //Counts up
         time += Time.deltaTime;
 
         //Check if its the right time to spawn the object
         if(time >= spawnTime){
             SpawnObject();
             SetRandomTime();
         }
 
     }
 
 
     //Spawns the object and resets the time
     void SpawnObject(){
         time = 0;
         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
      GameObject lt = Instantiate (spawnObject,spawnPos, spawnObject.transform.rotation);
     }
 
     //Sets the random time between minTime and maxTime
     void SetRandomTime(){
         spawnTime = Random.Range(minTime, maxTime);
     }
 
}
