using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPrintedCardItem : MonoBehaviour
{
    void Start()
    {
       LeanTween.scale(gameObject, Vector3.one, .5f);
    }
}
