using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private float _timeLeft;
    public float TimeLeft{ get => _timeLeft; set => _timeLeft = value; }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timeLeft > 0.0f)
        {
            _timeLeft -= Time.deltaTime;
        }
        ServiceLocator.Get<UIManager>().UpdateLevelTimer(_timeLeft);
        if(_timeLeft <=0.0f)
            ServiceLocator.Get<UIManager>().DisplayLoseText();
    }
}
