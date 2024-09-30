using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarPulse : MonoBehaviour
{
    [SerializeField] private GameObject rPing;
    private Transform pulseTransform;
    [SerializeField] private float range;
    [SerializeField] private float maxRange;

    private List<Collider> alreadyHit;

    private void Awake()
    {
        pulseTransform = transform.Find("Pulse");
        alreadyHit = new List<Collider>();
    }

    private void Update()
    {
        float rangeSpeed = 2f;
        range += rangeSpeed * Time.deltaTime;

        if (range > maxRange)
        {
            range = 0f;
            alreadyHit.Clear();
        }
        pulseTransform.localScale = new Vector3(range, range);
        //make pulse bigger over time

        Collider[] collidersHitArray = Physics.OverlapSphere(pulseTransform.position, range);

        foreach(Collider collider in collidersHitArray)
        {
            if (collider != null)
            {
                if (!alreadyHit.Contains(collider))
                {
                    alreadyHit.Add(collider);
                    Instantiate(rPing, collider.transform.position, Quaternion.identity);
                }
            }
        }
    }

}
