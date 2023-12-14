using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAndTimer : MonoBehaviour
{
    [SerializeField] private float _timerCount;
    [SerializeField] private TMP_Text _timer;
    [SerializeField] private TMP_Text _score;
    [SerializeField] private GameObject _gameOver;

    private void Start()
    {
        _timer.text = _timerCount.ToString();
    }

    private void Update()
    {
        _timerCount -= Time.deltaTime;
        _timer.text = Mathf.CeilToInt(_timerCount).ToString();

        if(_timerCount < 0 )
        {
            _timerCount = 0;
            _gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
