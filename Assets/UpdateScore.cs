using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmp;

    private int _score;

    private void Update()
    {
        _score = Mathf.FloorToInt(transform.position.y);
        tmp.text = _score.ToString();
    }
}
