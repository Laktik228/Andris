using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTetrisItem : MonoBehaviour
{
    public GameObject[] tetrisItem;
    private TetrisItemI figure;
    private int IndexOfItem;
    public bool isspawned;

    // Start is called before the first frame update
    void Start()
    {
        SpawningTheFigure();
        figure = FindObjectOfType<TetrisItemI>();
    }

   private void OnTriggerExit2D(Collider2D other)
   {
        isspawned = false;
        other.enabled = false;
   }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isspawned = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        isspawned = true;
    }
    private void SpawningTheFigure()
    {
        IndexOfItem = Random.Range(0, tetrisItem.Length);
        tetrisItem[IndexOfItem].transform.position = transform.position;
        Instantiate(tetrisItem[IndexOfItem]);
        isspawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isspawned & figure.issnapped)
        {
            SpawningTheFigure();
        }
    }
}
