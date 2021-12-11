using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MiniBossData", menuName="MiniBoss Data")]
public class MiniBossData : ScriptableObject
{

    [SerializeField] private string minibossName;
    [SerializeField] private int hp;
    [SerializeField] private int Speed;
    [SerializeField] private float distanceRay;
    [SerializeField] private int miniBossDamage;
}
