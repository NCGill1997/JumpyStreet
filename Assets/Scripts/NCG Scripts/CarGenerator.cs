using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarGenerator : MonoBehaviour
{
    
    public GameObject[] carPrefabs = new GameObject[4];
    private GameObject[] carsInPlay = new GameObject[3];
    public GameObject[] lanes = new GameObject[3];
    //public GameObject[] laneEnds = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LaneSpawning1());
        StartCoroutine(LaneSpawning2());
        StartCoroutine(LaneSpawning3());

    }

    //Spawning rates are hard-coded for now.  These can be easily randomized, but for testing purposes it was easier to just use hard-coded
    //times.  Each of these 

    private IEnumerator LaneSpawning1()
    {
        int car = Random.Range(0, 4);
        
        yield return new WaitForSeconds(3);
        carsInPlay[0] = Instantiate(carPrefabs[car], lanes[0].transform.position, lanes[0].transform.rotation);
        
        StartCoroutine(LaneSpawning1());

        /*for (int i = 0; i < 3; i++)
        {
            int car = Random.Range(0, 4);
            yield return new WaitForSeconds(i);
            carsInPlay[i] = Instantiate(carPrefabs[car], lanes[i].transform.position, lanes[i].transform.rotation);
        }*/  //This is an attempt to make the code a little better.  Will re-visit this later on.
        //StartCoroutine(LaneSpawning1());
    }

    private IEnumerator LaneSpawning2()
    {
        int car = Random.Range(0, 4);
        yield return new WaitForSeconds(2);
        carsInPlay[1] = Instantiate(carPrefabs[car], lanes[1].transform.position, lanes[0].transform.rotation);
        
        StartCoroutine(LaneSpawning2());
    }

    private IEnumerator LaneSpawning3()
    {
        int car = Random.Range(0, 4);
        yield return new WaitForSeconds(1);
        carsInPlay[2] = Instantiate(carPrefabs[car], lanes[2].transform.position, lanes[0].transform.rotation);
        
        StartCoroutine(LaneSpawning3());
    }
}
