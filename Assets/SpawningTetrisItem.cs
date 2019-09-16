using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTetrisItem : MonoBehaviour
{
    public GameObject[] tetrisItem;
    // Start is called before the first frame update
    void Start()
    {
        int IndexOfItem = Random.Range(0, tetrisItem.Length);
        tetrisItem[IndexOfItem].transform.GetChild(0).position = transform.position;
        Instantiate(tetrisItem[IndexOfItem]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
