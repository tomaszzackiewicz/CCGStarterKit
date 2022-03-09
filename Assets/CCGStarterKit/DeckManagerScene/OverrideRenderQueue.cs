using UnityEngine;
using System.Collections;

public class OverrideRenderQueue : MonoBehaviour {
    public int queueOrder = 0;

    void Start ()
    {
        GetComponent<Renderer>().material.renderQueue = queueOrder;
    }
}
