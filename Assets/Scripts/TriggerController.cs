using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerController : MonoBehaviour
{

    List<int> goalList;
    List<int> getList;
    [SerializeField] private string _name;
    
    [SerializeField] private GameObject _player;

    public GameController gameController;

    void OnTriggerEnter(Collider other)
    {

        //print("Enter OnTrigger Method");
        if (other.tag == "Player")
        {
            //print("if detected");
            goalList = gameController._generatedFood;
            //print("goal list detected");
            getList = gameController._idGrabbedFood;
            //print("getCurrentList detected");
            print(_isSame(goalList, getList));
            
            print("To activate laserpoint");
            gameController._canvasToPay.SetActive(true);
            _activateLaserPoint();
            print("Laser point was activated.");
        }
    }

    bool _isSame(List<int> A, List<int> B)
    {
        if (A.Count != B.Count)
        {
            return false;
        }
        List<int> ASort = A.ToList();
        ASort.Sort();
        List<int> BSort = B.ToList();
        BSort.Sort();

        for (int i = 0; i < ASort.Count; i++)
        {
            if (ASort[i] != BSort[i])
            {
                return false;
            }
        }
        return true;
    }

    // private GameObject FindChildGameObjectByName(GameObject topParentGameObject, string gameObjectName)
    // {
    //     for (int i = 0; i < topParentGameObject.transform.childCount; i++)
    //     {
    //         if (topParentGameObject.transform.GetChild(i).name == gameObjectName)
    //         {
    //             return topParentGameObject.transform.GetChild(i).gameObject;
    //         }

    //         GameObject tmp = FindChildGameObjectByName(topParentGameObject.transform.GetChild(i).gameObject, gameObjectName);
    //     }

    //     return null;
    // }
    void _activateLaserPoint()
    {
        gameController._laserpoint.SetActive(true);
    }
    public void _validateResultProducts(){
        if(_isSame(goalList, getList) == true){
            print("To validate products");
            gameController._imageResultProducts.sprite = gameController._ok;
            print("Products were validated.");
        }else{
            print("To validate products");
            gameController._imageResultProducts.sprite = gameController._noOk;
            print("Products were validated.");
        }
    }
}
