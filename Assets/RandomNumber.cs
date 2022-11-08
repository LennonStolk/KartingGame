using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    public int Number { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Number = Random.Range(0, int.MaxValue);
    }
}