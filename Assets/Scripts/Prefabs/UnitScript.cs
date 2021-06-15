using System.Collections;
using System.Collections.Generic;
using Prefabs;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private UnitLeg leftLeg;
    [SerializeField] private UnitLeg rightLeg;
    private bool _leftLegPositive;
    private float _currentLeftLegX = 45f;
    public int speed;
    public bool go;

    // Start is called before the first frame update
    void Start()
    {
        int legSpeed = speed * 100;
        leftLeg.SetPositive(true);
        leftLeg.SetSpeed(legSpeed);
        rightLeg.SetPositive(false);
        rightLeg.SetSpeed(legSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        // transform.Rotate(0, 0, 1);
        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        }
    }
}