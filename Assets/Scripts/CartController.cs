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
            
            gameController.printID();
            gameController._audioPlayer.Play();
            obj.gameObject.SetActive(false);
            print("Object was deleted from scene.");
            
        }


    }

}
