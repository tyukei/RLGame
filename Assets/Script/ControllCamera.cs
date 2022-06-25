using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCamera : MonoBehaviour
{
    [SerializeField]private GameObject _agent;
    [SerializeField] private float fOffset = 5;
    private float posx;

    void Update()
    {
            posx = _agent.transform.position.x + fOffset;
            this.transform.position = new Vector3(posx, transform.position.y, transform.position.z);
    }
}
