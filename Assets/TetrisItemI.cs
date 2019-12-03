using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisItemI : MonoBehaviour
{ 
    public bool issnapped;
    public bool following;

    protected Grid gridobj;

    private AudioSource clipToPlay;
    public float offset = 0.05f;
    public AudioClip click;
    
    void Awake()
    {
        clipToPlay = GetComponent<AudioSource>();
        issnapped = false;
        gridobj = FindObjectOfType<Grid>();
        following = false;
        offset += 10;
    }

  // Update is called once per frame
    void Update () 
    {
        
        if(Input.GetMouseButtonDown(0) && ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).magnitude <= offset))
        {
            if (following)
            {
                following = false;
                if(this.tag == "I") 
                {
                    transform.GetChild(0).position = gridobj.GetCellCenterLocal(gridobj.LocalToCell(transform.GetChild(0).position));
                }
                else
                {
                    transform.position = gridobj.GetCellCenterLocal(gridobj.LocalToCell(transform.position));
                }
                issnapped = true;
            }
            else
            {
                following = true;
                issnapped = false;
            }
            
        }
        if (following & !issnapped)
        {
            foreach(Transform child in transform)
            {
                child.localScale = new Vector2(1.4f, 1.4f);
            } 
            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 1f);
        }
    }
}    
