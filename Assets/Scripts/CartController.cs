using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CartController : MonoBehaviour
{
    public GameController gameController;
    List<GameObject> _grabbedFood = new List<GameObject>();
    void Start()
    {

        _grabbedFood.Clear();

    }
    void OnCollisionEnter(Collision obj)
    {

        if (obj.gameObject.tag == "Floor")
        {
            print("Ignored Floor Collision");
        }
        else
        {
            gameController.TargetHit(obj.gameObject);
            _grabbedFood.Add(obj.gameObject);
            
            //_getID(obj.gameObject);
            gameController.printID();
            
        }


    }
    // void _getID(GameObject obj)
    // {
    //     if (obj.gameObject.tag == "Pineapple")
    //     {
    //         _nextID = obj.gameObject.GetComponent<setID>()._getID();
    //         _idGrabbedFood.Add(_nextID);

    //     }
    //     else if (obj.gameObject.tag == "Watermelon")
    //     {
    //         _nextID = obj.gameObject.GetComponent<setID>()._getID();
    //         _idGrabbedFood.Add(_nextID);
    //     }
    //     else if (obj.gameObject.tag == "Mango")
    //     {
    //         _nextID = obj.gameObject.GetComponent<setID>()._getID();
    //         _idGrabbedFood.Add(_nextID);
    //     }
    // }
}
