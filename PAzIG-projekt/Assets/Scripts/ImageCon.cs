using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCon : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (GamePlay.textPointer ==1)
        {
            GetComponent<SpriteRenderer>().sprite = image1;
        }
         if  (GamePlay.textPointer ==2)
        {
            GetComponent<SpriteRenderer>().sprite = image2;
        }
         if  (GamePlay.textPointer ==3)
        {
            GetComponent<SpriteRenderer>().sprite = image3;
        }
         if  (GamePlay.textPointer ==4)
        {
            GetComponent<SpriteRenderer>().sprite = image4;
        }
         if  (GamePlay.textPointer ==5)
        {
            GetComponent<SpriteRenderer>().sprite = image5;
        }
         if  (GamePlay.textPointer ==6)
        {
            GetComponent<SpriteRenderer>().sprite = image6;
        }
        
    }
    void OnMouseDown()
    {
        GamePlay.currentSelection=gameObject.name;
        Debug.Log(gameObject.name);
    }
}
