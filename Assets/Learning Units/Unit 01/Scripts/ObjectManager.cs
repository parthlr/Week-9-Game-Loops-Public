using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // DIRECTIONS: You do not need to write any new code for Unit 01, nor do you need to fix the scene, 
    // nor do you need to adjust project settings. You need to rearrange the lines of code, though;
    // The goal is for the red cubes to spread out in a line and move across the screen.

    [SerializeField] List<GameObject> objects;

    MoveObjects objectMover;

    void Awake()
    {
        // Move initialization to awake
        objectMover = GetComponent<MoveObjects>();
        objectMover.ObjectsToMove = objects;
        objectMover.StartMovement();
    }
    // Start is called before the first frame update
    void Start()
    {
    }
}
