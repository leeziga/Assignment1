using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private int _value;
    //[SerializeField] private float _addTime;
    [SerializeField] private bool _advanceToNextLevel;

    public int Value { get { return _value; } private set { _value = value; } }
    //public float AddTime { get { return _addTime; } private set { _addTime = value; } }
    public bool AdvanceToNextLevel { get { return _advanceToNextLevel; } private set { _advanceToNextLevel = value; } }

    public int Collect()
    {
        this.gameObject.SetActive(false);
        return Value;
    }
}
