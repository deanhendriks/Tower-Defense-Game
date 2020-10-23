﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    void Start() {
        StartCoroutine(ShakeCamera(0.0f));
    }

   public IEnumerator ShakeCamera(float shakeAmount)
    {
        Vector3 startPosition = transform.position;
        for(int i = 0; i < 5; i++)
        {
            transform.position += new Vector3(
                Random.Range(-shakeAmount, shakeAmount),
                Random.Range(-shakeAmount, shakeAmount),
                Random.Range(-shakeAmount, shakeAmount));
            yield return null;
        }
        transform.position = startPosition;
    }
}
