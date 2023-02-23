using UnityEngine;

public class check : MonoBehaviour
{
    public GameObject destroyObject;
    public string requiredTag;
    public Transform referencePoint;
    public GameObject GO;
    public int scoreCount=0;


    private void OnMouseUp()
    {
        
    }
    void OnTriggerEnter(Collider mainCollider)
    {
        if (mainCollider.gameObject.tag == requiredTag)
        {
            Destroy(destroyObject.gameObject);
            Debug.Log(GO);
            if(gameObject.name == "5holes_bent agay")
            {
                gameObject.transform.parent = GO.transform;
                //object1 is now the child of object2
            }

            // collider.gameObject.transform.parent = this.transform;
            mainCollider.gameObject.transform.position = referencePoint.position;
            Debug.Log("Collided with :" + mainCollider.gameObject.name);  //asal wala
            Debug.Log("Collided with :" + gameObject.name);   //referencewala
            Debug.Log("ABC");
            GameManager.instance.StepsCounter(scoreCount);
        }
        else
        {
            Debug.Log("123");
        }

       
    }




    /*private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.contacts.Lenght);
    }*/

}

