using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisItem : MonoBehaviour
{ 
    private bool following;
    private AudioSource clipToPlay;
    public float offset = 0.05f;
    public AudioClip click;
    
    void Start()
    {
        clipToPlay = GetComponent<AudioSource>();
        following = false;
        offset += 10;
    }
  // Update is called once per frame
    void Update () 
    {
        if(Input.GetMouseButton(0) && ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).magnitude <= offset))
        {
            clipToPlay.clip = click;
            clipToPlay.Play();
            if (following)
            {
                following = false;
            }
            else
            {
                following = true;
            }
        }
        if (following)
        {
        
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.1f);
        
        }
    }
}
