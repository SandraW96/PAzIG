using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public Transform aTestObj;  //question test object
    List<string> questions = new List<string>() {"","k. czworoboczna", "k. główkowata", "k. łódeczkowata", "k. haczykowata", "k. promieniowa", "k. łokciowa", "głowa kości skokowej", "k. łódkowata", "k. piętowa", "k. piszczelowa", "k. strzałkowa", "zatoka stępu", "brzeg łopatki", "guzek większy kości ramiennej", "kąt łopatki", "obojczyk", "szyjka chirurgiczna", "wyrostek barkowy łopatki"};
    public static int textPointer;
    List<string> correctSelection = new List<string> {"","Answer1", "Answer1", "Answer1", "Answer1", "Answer1", "Answer1", "Answer2", "Answer2", "Answer2", "Answer2", "Answer2", "Answer2", "Answer3", "Answer3", "Answer3", "Answer3", "Answer3", "Answer3"};
    public static string currentSelection;

    // Start is called before the first frame update
    void Start()
    {
        textPointer=Random.Range(1,7);
    }

    // Update is called once per frame
    void Update()
    {
        aTestObj.GetComponent<TextMesh>().text = questions[textPointer];

        if (currentSelection==correctSelection[textPointer])
        {
            Debug.Log("Correct");
        }
    }
}
