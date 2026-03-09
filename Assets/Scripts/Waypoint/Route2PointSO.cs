using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Waypoint/Route 2 Point (Position)", fileName = "Route2PointPos")]
public class Route2PointPosSO : ScriptableObject
{
    public Vector3 pointA;
    public Vector3 pointB;
}