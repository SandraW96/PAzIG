using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public Transform qTestObj;  //question test object
    // Start is called before the first frame update
    void Start()
    {
        qTestObj.GetComponent<TextMesh>().text = "An apple";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
