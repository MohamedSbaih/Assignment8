using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ass8Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string []   words = {"Cat ", " Dog", " Car", " Pizza", " Hat", " Fish", " Tree", " Monkey", " Ball", " Bird"};
        
        int count = 0;
        string funnyWords = "";
        while(count < 7){
            count++;
            int wordsIndex = Random.Range(0,words.Length);
            funnyWords += words[wordsIndex];

        }
        Debug.Log(funnyWords);
    }

  
}
