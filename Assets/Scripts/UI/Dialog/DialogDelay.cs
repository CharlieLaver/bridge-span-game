using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogDelay : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    void Start()
    {
        
           StartCoroutine(Type());
        
    }

     IEnumerator Type()
    {
        yield return new WaitForSeconds(3);
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
         
    }

    
}
