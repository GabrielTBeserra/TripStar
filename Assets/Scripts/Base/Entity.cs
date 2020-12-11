using Assets.Scripts.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField]
    public Life life;
    [SerializeField]
    public Speed speed;
    [SerializeField]
    public Points points;
}
