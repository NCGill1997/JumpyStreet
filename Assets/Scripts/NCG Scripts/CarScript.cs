using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarScript : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(DestroySelf());
    }

    private void Update() //Movement for the car.
    {
        transform.Translate(new Vector3(0, -Time.deltaTime * 3, 0));
    }

    //Check collision for the collider that destroys the cars, and the collider of the player.
    public void OnColliderEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Destroy")
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
        //This was not working, for some reason.  
        //The collider, whether a trigger or not, was refusing to call this method.
        //Went with plan B for now.

        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hit " + this.gameObject.name); //Placeholder.  Will affect the player further on
        }
    }


    IEnumerator DestroySelf()  //This was the "Plan B" for the destruction of the cars.
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Destroy" + this.gameObject.name);
        Destroy(gameObject);
    }
}
