using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGenerator : MonoBehaviour
{

private const float GeneratingDistance = 25f;

[SerializeField] public Transform levelPart_Start; 
[SerializeField] public List<Transform> levelPartList;
[SerializeField] public Transform player; 

private Vector3 lastEndPosition; 

private void Awake(){
 lastEndPosition = levelPart_Start.Find("EndPosition").position;
 
  int startingSpawnLevelParts = 5;
  for (int i = 0; i < startingSpawnLevelParts; i++)
  {
      SpawnLevelPart();
  }
   
}

 private void Update(){
    if (Vector3.Distance(player.position, lastEndPosition) < GeneratingDistance)
    {
        //spawn new platform 
        SpawnLevelPart();
    }
} 

private void SpawnLevelPart(){
Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)]; 
Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
lastEndPosition = lastLevelPartTransform.transform.Find("EndPosition").position;
}

private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition){
    Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
    return levelPartTransform;
}
}