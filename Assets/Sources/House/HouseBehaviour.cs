using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class HouseBehaviour : ScriptableObject
{
    public int ClicksToBuild;
    public int ClickMoney;
    public int BuildMoney;

    [Space]

    public int ClickCount;

    public bool Builded;
}
