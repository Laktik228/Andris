using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public SpriteRenderer BackgroundSprite;
    void Awake()
    {
        BackgroundSprite = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(BackgroundSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
