using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    // DIRECTIONS: Get the objects to move back and forth.
    List<GameObject> ObjectsToMove { get; set; }
    List<Vector3> startPositions;
    List<Vector3> endPositions;

    float moveAmount = 0.01f; // Don't change this line!
    float lerpAmount = 0; // Don't change this line!

    // Start is called before the first frame update
    void Start()
    {
        ObjectsToMove = GetComponent<MoveObjects>().ObjectsToMove; // Keep this line and don't change it.
        GetComponent<MoveObjects>().enabled = false; // Keep this line and don't change it.
        
        //DIRECTIONS: Uncomment the lines below and fix them
        startPositions = new List<Vector3>();
        endPositions = new List<Vector3>();
        foreach(GameObject g in ObjectsToMove)
        {
            startPositions.Add(g.transform.position); // one of these lists needs this kind of position...
            endPositions.Add(g.transform.position + new Vector3(0,0,10f)); // another one needs another...
        }
    }

    // Update is called once per frame
    void Update()
    {
        //DIRECTIONS: Uncomment the lines below and fix them
        for (int i = 0; i < ObjectsToMove.Count; i++)
        {
            ObjectsToMove[i].transform.position = Vector3.Lerp(startPositions[i], endPositions[i], lerpAmount);
        }

        //Don't change anything below here!
        lerpAmount += moveAmount;

        if (lerpAmount < 0 || lerpAmount > 1)
        {
            moveAmount = -moveAmount;
        }
        
    }
}
