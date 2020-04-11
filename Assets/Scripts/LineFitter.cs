using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineFitter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] pos;
    Vector3[] posVect;
    private LineRenderer lr;
    int i = 0;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        posVect = new Vector3[4];
    }
    
    // Update is called once per frame
    void Update()
    {
        i = 0;
        foreach (var item in pos)
        {
            posVect[i] = item.transform.position;
            i++;
        }
        lr.SetPositions(posVect);
    }
}
