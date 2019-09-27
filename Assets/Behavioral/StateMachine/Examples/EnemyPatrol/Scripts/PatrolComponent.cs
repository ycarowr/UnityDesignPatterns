using EnemyPatrol;
using UnityEngine;

public class PatrolComponent : MonoBehaviour
{
    [SerializeField] Transform PointA;
    [SerializeField] Transform PointB;

    Patrol Patrol { get; set; }

    void Start()
    {
        Patrol = new Patrol(PointA.position, PointB.position, this);
        Patrol.Initialize();
    }
}