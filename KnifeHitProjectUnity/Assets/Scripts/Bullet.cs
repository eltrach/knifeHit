using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int bulletSpeed = 100; 

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] impactSound;

    private bool isCollided =false;



    void Update()
    {
        if(!isCollided)
        gameObject.transform.localPosition += Vector3.up * bulletSpeed * Time.deltaTime;

    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="wooden")
        {
            
            isCollided= transform;
            gameObject.transform.SetParent(other.gameObject.transform);
            gameObject.transform.SetAsFirstSibling();


            audioSource = GetComponentInParent<AudioSource>();
            // play a random sound on Impact
            var rand = impactSound[Random.Range(0,impactSound.Length)];
            audioSource.PlayOneShot(rand);

        }else{
            gameManager.instance.GameOver();
        }
    }
}
