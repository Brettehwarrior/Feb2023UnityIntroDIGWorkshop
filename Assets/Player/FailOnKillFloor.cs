using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailOnKillFloor : MonoBehaviour
{
    [SerializeField] private GameObject restartMenuCanvas;

    private void Awake()
    {
        restartMenuCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Kill Floor"))
        {
            Kill();
        }
    }

    private void Kill()
    {
        restartMenuCanvas.SetActive(true);
        Debug.Log("Oof");
        Destroy(gameObject);
    }
}
