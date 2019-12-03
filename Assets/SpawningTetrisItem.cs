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
        IndexOfItem = Random.Range(0, tetrisItem.Length);
        tetrisItem[IndexOfItem].transform.position = transform.position;
        Instantiate(tetrisItem[IndexOfItem]);
        isspawned = true;
        figure = FindObjectOfType<TetrisItemI>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(figure.issnapped){
            if(!isspawned){
                if(this.tag == "SpawnPoint1")
            {
                SpawningTheFigure();
            }
            else if(this.tag == "SpawnPoint2")
            {
                SpawningTheFigure();
            }
            else if(this.tag == "SpawnPoint3")
            {
                SpawningTheFigure();
            }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(figure.issnapped){
            if(!isspawned){
                if(this.tag == "SpawnPoint1")
            {
                SpawningTheFigure();
            }
            else if(this.tag == "SpawnPoint2")
            {
                SpawningTheFigure();
            }
            else if(this.tag == "SpawnPoint3")
            {
                SpawningTheFigure();
            }
            }
        }
    }
    private void SpawningTheFigure(){
        IndexOfItem = Random.Range(0, tetrisItem.Length);
        tetrisItem[IndexOfItem].transform.position = this.transform.position;
        Instantiate(tetrisItem[IndexOfItem]);
        isspawned = true;
        }
}
