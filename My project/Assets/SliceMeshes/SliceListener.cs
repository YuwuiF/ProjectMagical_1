using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceListener : MonoBehaviour
{
    public Slicer slicer;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter!");
        Debug.Log(slicer.isTouched);
        slicer.isTouched = true;
        Debug.Log(slicer.isTouched);
    }
}
