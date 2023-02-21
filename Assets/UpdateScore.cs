using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmp;

    private void Update()
    {
        tmp.text = Mathf.Floor(transform.position.y).ToString();
    }
}
