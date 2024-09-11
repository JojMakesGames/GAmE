using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
   public Transform GetWaypoint(int waypointindex)
    {
        return transform.GetChild(waypointindex);
    }
    public int GetNextWaypointIndex(int currentwaypointindex)
    {
        int nextwaypointindex = currentwaypointindex + 1;

        if (nextwaypointindex == transform.childCount)
        {
            nextwaypointindex = 0;
        }
        return nextwaypointindex;
    }

}
