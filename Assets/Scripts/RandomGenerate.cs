using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerate : MonoBehaviour
{
    [SerializeField] private string[] messages;//В данный массив будут записаны все ответы
    [SerializeField] private Text messageText; //Строка для ответов

    public void GenerateMesage()
    {
        messageText.text = messages[Random.Range(0, messages.Length)];
    }

}



