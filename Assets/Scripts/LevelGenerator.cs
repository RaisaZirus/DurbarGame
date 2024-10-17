using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform level_part_start;
    [SerializeField] private List<Transform> levelpartlist;
    [SerializeField] private Player player;

    private const float DISTANCE_TO_LEVEL_BOUNDARY = 20f; 
    private Vector3 last_end_position;
    
    private void Start()
    {
        //player = FindObjectOfType<Player>();
    }

    private void Awake() //Called before Start
    {
        last_end_position = level_part_start.Find("EndPosition").position;

        int starting_spawn_level_num = 1;
        for(int i = 0; i<= starting_spawn_level_num; i++)
        {
            SpawnLevelPart();
        }
    }
    void Update() //The game loop 
    {   //there will be a bug if you write player.GetPosition(), you should write player.transform.position .....
        if(Vector3.Distance(player.transform.position,last_end_position) < DISTANCE_TO_LEVEL_BOUNDARY) 
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosen_level_part = levelpartlist[Random.Range(0, levelpartlist.Count)];
        Transform last_level_part = Spawnner(chosen_level_part , last_end_position);
        last_end_position = last_level_part.Find("EndPosition").position;
    }

    private Transform Spawnner(Transform level_part,Vector3 spawnposition)
    {
        Transform lastlevel_end_transform = Instantiate(level_part, spawnposition, Quaternion.identity);
        //Instantiate returns the transform of an object instantiated 
        return lastlevel_end_transform;
    }



 }
    