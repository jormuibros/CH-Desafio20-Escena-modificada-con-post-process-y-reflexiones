using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SkeletonData", menuName="Skeleton Data")]
public class SkeletonData : ScriptableObject
{
    [SerializeField] private string Skeletonname;
    [SerializeField] private int hp;
    [SerializeField] private int Speed;
    [SerializeField] private float distanceRay;
    [SerializeField] public float enemydamage;
}
