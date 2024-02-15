using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TriggerController : MonoBehaviour
{

    List<int> goalList;
    List<int> getList;
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
}
