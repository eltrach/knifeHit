using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    [SerializeField] int knifes = 7;

    [SerializeField] private GameObject KnifeObject;
    [SerializeField] private Transform KnifeSpawnPoint;

    [SerializeField] private TextMeshProUGUI KnifeLeftText;
    

    public void Fire()
    {
        KnifeLeftText.text = "KNIFE LEFT : " + knifes;
        if(knifes > 0)
        {
            knifes--;
            
            Instantiate(KnifeObject,KnifeSpawnPoint);

        }
    }


  
}
