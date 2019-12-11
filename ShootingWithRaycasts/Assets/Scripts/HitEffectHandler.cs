﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffectHandler : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(DeactivateInpactParticle());
    }

    IEnumerator DeactivateInpactParticle()
    {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
    }
}
