using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UltimateXR.Extensions.System.Collections;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public List<GameObject> _pineapple;
    public List<GameObject> _watermelon;
    public List<GameObject> _mango;
    public List<GameObject> _banana;
    public List<GameObject> _pear;
    public List<GameObject> _apple;
    public List<GameObject> _orangeJuice;
    public List<GameObject> _chocolate;
    public List<GameObject> _coffee;
    public List<GameObject> _milk;
    public List<GameObject> _wine;
    public List<int> _idGrabbedFood = new List<int>();
    public List<int> _randomFood = new List<int>();
    public List<int> _generatedFood = new List<int>();
    public TextMeshProUGUI _textTotalValue;
    public TextMeshProUGUI _textWatermelonQuantity;
    public TextMeshProUGUI _textPineappleQuantity;
    public TextMeshProUGUI _textMangoQuantity;
    public TextMeshProUGUI _textBananaQuantity;
    public TextMeshProUGUI _textPearQuantity;
    public TextMeshProUGUI _textAppleQuantity;
    public TextMeshProUGUI _textOrangeJuiceQuantity;
    public TextMeshProUGUI _textChocolateQuantity;
    public TextMeshProUGUI _textCoffeeQuantity;
    public TextMeshProUGUI _textMilkQuantity;
    public TextMeshProUGUI _textWineQuantity;
    public TextMeshProUGUI _textGoalWatermelonQuantity;
    public TextMeshProUGUI _textGoalPineappleQuantity;
    public TextMeshProUGUI _textGoalMangoQuantity;
    public TextMeshProUGUI _textGoalBananaQuantity;
    public TextMeshProUGUI _textGoalPearQuantity;
    public TextMeshProUGUI _textGoalAppleQuantity;
    public TextMeshProUGUI _textGoalOrangeJuiceQuantity;
    public TextMeshProUGUI _textGoalChocolateQuantity;
    public TextMeshProUGUI _textGoalCoffeeQuantity;
    public TextMeshProUGUI _textGoalMilkQuantity;
    public TextMeshProUGUI _textGoalWineQuantity;
    private int _value;
    private int _watermelonQ;
    private int _pineappleQ;
    private int _mangoQ;
    private int _bananaQ;
    private int _pearQ;
    private int _appleQ;
    private int _orangeJuiceQ;
    private int _chocolateQ;
    private int _coffeeQ;
    private int _milkQ;
    private int _wineQ;
    private int _pickedWatermelon = 0;
    private int _pickedPineapple = 0;
    private int _pickedMango = 0;
    private int _pickedBanana = 0;
    private int _pickedPear = 0;
    private int _pickedApple = 0;
    private int _pickedOrangeJuice = 0;
    private int _pickedChocolate = 0;
    private int _pickedCoffee = 0;
    private int _pickedMilk = 0;
    private int _pickedWine = 0;
    public int _difficultID;
    public int _totalElements;
    public int _difficultElements;
    public float _setTimebyDifficult;
    public GameObject _canvasGoal;
    public GameObject _canvasGrabbed;

    // Start is called before the first frame update
    void Start()
    {
        _initialFill();
        _generateFoodbyDifficult();
        _canvasGrabbed.SetActive(false);
        StartCoroutine(_hideUI(_canvasGoal, _setTimebyDifficult));
        //StartCoroutine(_hideUI(_canvasGrabbed, _setTimebyDifficult, true));
        StartCoroutine(_showUI(_canvasGrabbed, _setTimebyDifficult));
    }

    public void TargetHit(GameObject obj)
    {
        if (_pineapple.Contains(obj))
        {
            _value += 4;
            _pineappleQ += 1;
            _idGrabbedFood.Add(1);
            _pineapple.Remove(obj);
            Debug.Log("Score: " + _value);
            _textTotalValue.text = "Total: " + _value;
            _textPineappleQuantity.text = "x " + _pineappleQ;

        }
        else if (_watermelon.Contains(obj))
        {
            _value += 5;
            _watermelonQ += 1;
            _idGrabbedFood.Add(2);
            _watermelon.Remove(obj);
            Debug.Log("Score: " + _value);
            _textTotalValue.text = "Total: " + _value;
            _textWatermelonQuantity.text = "x " + _watermelonQ;

        }
        else if (_mango.Contains(obj))
        {
            _value += 3;
            _mangoQ += 1;
            _idGrabbedFood.Add(3);
            _mango.Remove(obj);
            Debug.Log("Score: " + _value);
            _textTotalValue.text = "Total: " + _value;
            _textMangoQuantity.text = "x " + _mangoQ;

        }
        else if (_banana.Contains(obj))
        {
            _value += 2;
            _bananaQ += 1;
            _idGrabbedFood.Add(4);
            _banana.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textBananaQuantity.text = "x " + _bananaQ;

        }
        else if (_pear.Contains(obj))
        {
            _value += 1;
            _pearQ += 1;
            _idGrabbedFood.Add(5);
            _pear.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textPearQuantity.text = "x " + _pearQ;

        }
        else if (_apple.Contains(obj))
        {
            _value += 1;
            _appleQ += 1;
            _idGrabbedFood.Add(6);
            _apple.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textAppleQuantity.text = "x " + _appleQ;

        }
        else if (_orangeJuice.Contains(obj))
        {
            _value += 2;
            _orangeJuiceQ += 1;
            _idGrabbedFood.Add(7);
            _orangeJuice.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textOrangeJuiceQuantity.text = "x " + _orangeJuiceQ;

        }
        else if (_chocolate.Contains(obj))
        {
            _value += 2;
            _chocolateQ += 1;
            _idGrabbedFood.Add(8);
            _chocolate.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textChocolateQuantity.text = "x " + _chocolateQ;

        }
        else if (_coffee.Contains(obj))
        {
            _value += 4;
            _coffeeQ += 1;
            _idGrabbedFood.Add(9);
            _coffee.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textCoffeeQuantity.text = "x " + _coffeeQ;

        }
        else if (_milk.Contains(obj))
        {
            _value += 1;
            _milkQ += 1;
            _idGrabbedFood.Add(10);
            _milk.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textMilkQuantity.text = "x " + _milkQ;

        }
        else if (_wine.Contains(obj))
        {
            _value += 5;
            _wineQ += 1;
            _idGrabbedFood.Add(11);
            _wine.Remove(obj);
            _textTotalValue.text = "Total: " + _value;
            _textWineQuantity.text = "x " + _wineQ;

        }
    }

    public void printID()
    {
        foreach (int item in _idGrabbedFood)
        {
            print(item);
        }
    }

    public void _initialFill()
    {
        _value = 0;
        _watermelonQ = 0;
        _pineappleQ = 0;
        _mangoQ = 0;
        _bananaQ = 0;
        _pearQ = 0;
        _appleQ = 0;
        _orangeJuiceQ = 0;
        _chocolateQ = 0;
        _coffeeQ = 0;
        _milkQ = 0;
        _wineQ = 0;
        _textTotalValue = GameObject.Find("TotalValue").GetComponent<TextMeshProUGUI>();
        // _textWatermelonQuantity = GameObject.Find("WatermelonText").GetComponent<TextMeshProUGUI>();
        // _textPineappleQuantity = GameObject.Find("PineappleText").GetComponent<TextMeshProUGUI>();
        // _textMangoQuantity = GameObject.Find("MangoText").GetComponent<TextMeshProUGUI>();
        // _textBananaQuantity = GameObject.Find("BananaText").GetComponent<TextMeshProUGUI>();
        // _textPearQuantity = GameObject.Find("PearText").GetComponent<TextMeshProUGUI>();
        // _textAppleQuantity = GameObject.Find("AppleText").GetComponent<TextMeshProUGUI>();
        // _textOrangeJuiceQuantity = GameObject.Find("OrangeJuiceText").GetComponent<TextMeshProUGUI>();
        // _textChocolateQuantity = GameObject.Find("ChocolateText").GetComponent<TextMeshProUGUI>();
        // _textCoffeeQuantity = GameObject.Find("CoffeeText").GetComponent<TextMeshProUGUI>();
        // _textMilkQuantity = GameObject.Find("MilkText").GetComponent<TextMeshProUGUI>();
        // _textWineQuantity = GameObject.Find("WineText").GetComponent<TextMeshProUGUI>();
        _textGoalWatermelonQuantity = GameObject.Find("GoalWatermelonText").GetComponent<TextMeshProUGUI>();
        _textGoalPineappleQuantity = GameObject.Find("GoalPineappleText").GetComponent<TextMeshProUGUI>();
        _textGoalMangoQuantity = GameObject.Find("GoalMangoText").GetComponent<TextMeshProUGUI>();
        _textGoalBananaQuantity = GameObject.Find("GoalBananaText").GetComponent<TextMeshProUGUI>();
        _textGoalPearQuantity = GameObject.Find("GoalPearText").GetComponent<TextMeshProUGUI>();
        _textGoalAppleQuantity = GameObject.Find("GoalAppleText").GetComponent<TextMeshProUGUI>();
        _textGoalOrangeJuiceQuantity = GameObject.Find("GoalOrangeJuiceText").GetComponent<TextMeshProUGUI>();
        _textGoalChocolateQuantity = GameObject.Find("GoalChocolateText").GetComponent<TextMeshProUGUI>();
        _textGoalCoffeeQuantity = GameObject.Find("GoalCoffeeText").GetComponent<TextMeshProUGUI>();
        _textGoalMilkQuantity = GameObject.Find("GoalMilkText").GetComponent<TextMeshProUGUI>();
        _textGoalWineQuantity = GameObject.Find("GoalWineText").GetComponent<TextMeshProUGUI>();
        _canvasGoal = GameObject.Find("CanvasGoalFood");
        _canvasGrabbed = GameObject.Find("CanvasGrabbedFood");
        _pineapple = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pineapple"));
        _watermelon = new List<GameObject>(GameObject.FindGameObjectsWithTag("Watermelon"));
        _mango = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mango"));
        _banana = new List<GameObject>(GameObject.FindGameObjectsWithTag("Banana"));
        _pear = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pear"));
        _apple = new List<GameObject>(GameObject.FindGameObjectsWithTag("Apple"));
        _orangeJuice = new List<GameObject>(GameObject.FindGameObjectsWithTag("OrangeJuice"));
        _chocolate = new List<GameObject>(GameObject.FindGameObjectsWithTag("Chocolate"));
        _coffee = new List<GameObject>(GameObject.FindGameObjectsWithTag("Coffee"));
        _milk = new List<GameObject>(GameObject.FindGameObjectsWithTag("Milk"));
        _wine = new List<GameObject>(GameObject.FindGameObjectsWithTag("Wine"));
        _difficultID = StateNameController._difficulty;
    }

    public void _generateFoodbyDifficult()
    {
        int _randomInt;
        int _pickedInt;
        int _pickedIndex;

        print("Is getting data from the past scene");
        if (_difficultID == 1)
        {
            _difficultElements = 3;
            _totalElements = 10;
            _setTimebyDifficult = 10.0f;
        }
        else if (_difficultID == 2)
        {
            _difficultElements = 4;
            _totalElements = 15;
            _setTimebyDifficult = 15.0f;
        }
        else if (_difficultID == 3)
        {
            _difficultElements = 5;
            _totalElements = 20;
            _setTimebyDifficult = 20.0f;
        }

        print("Selected Difficult: " + _difficultID);
        print("Total Type of Elements: " + _difficultElements);
        print("Total Elements: " + _totalElements);

        print("For to be initialized.");
        for (int i = 0; i < _difficultElements; i++)
        {
            print("For is working i = " + i);
            print("Do to be initialized.");
            do
            {
                _randomInt = Random.Range(1, 12);
                print("RandomInt was created.");
            } while (_randomFood.Contains(_randomInt));
            _randomFood.Add(_randomInt);
            print("RandomInt was added.");

        }
        print("For terminated.");
        print("The current list is: ");
        foreach (int item in _randomFood)
        {
            print(item);
        }

        print("For to be initialized.");
        for (int i = 0; i < _totalElements; i++)
        {
            print("For is working i = " + i);
            _pickedIndex = Random.Range(0, _randomFood.Count);
            print("A index of the previous list was selected.");
            _pickedInt = _randomFood[_pickedIndex];
            print("A RandomInt of the previous list was selected.");

            print("Switch to be initialized.");
            switch (_pickedInt)
            {
                case 1: _pickedPineapple++; _textGoalPineappleQuantity.text = "x " + _pickedPineapple; break;
                case 2: _pickedWatermelon++; _textGoalWatermelonQuantity.text = "x " + _pickedWatermelon; break;
                case 3: _pickedMango++; _textGoalMangoQuantity.text = "x " + _pickedMango; break;
                case 4: _pickedBanana++; _textGoalBananaQuantity.text = "x " + _pickedBanana; break;
                case 5: _pickedPear++; _textGoalPearQuantity.text = "x " + _pickedPear; break;
                case 6: _pickedApple++; _textGoalAppleQuantity.text = "x " + _pickedApple; break;
                case 7: _pickedOrangeJuice++; _textGoalOrangeJuiceQuantity.text = "x " + _pickedOrangeJuice; break;
                case 8: _pickedChocolate++; _textGoalChocolateQuantity.text = "x " + _pickedChocolate; break;
                case 9: _pickedCoffee++; _textGoalCoffeeQuantity.text = "x " + _pickedCoffee; break;
                case 10: _pickedMilk++; _textGoalMilkQuantity.text = "x " + _pickedMilk; break;
                case 11: _pickedWine++; _textGoalWineQuantity.text = "x " + _pickedWine; break;
            }
            print("Switch terminated.");

            _generatedFood.Add(_pickedInt);
            print("Selected int was added to the new list.");
        }
        print("For terminated.");
        print("The final list is: ");
        foreach (int item in _generatedFood)
        {
            print(item);
        }
    }

    IEnumerator _hideUI(GameObject guiParentCanvas, float secondsToWait, bool show = false)
    {
        yield return new WaitForSeconds(secondsToWait);
        guiParentCanvas.SetActive(show);
        
    }
    IEnumerator _showUI(GameObject guiParentCanvas, float secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
        guiParentCanvas.SetActive(true);
        _enableCanvas();
    }
    public void _enableCanvas(){
        _textWatermelonQuantity = GameObject.Find("WatermelonText").GetComponent<TextMeshProUGUI>();
        _textPineappleQuantity = GameObject.Find("PineappleText").GetComponent<TextMeshProUGUI>();
        _textMangoQuantity = GameObject.Find("MangoText").GetComponent<TextMeshProUGUI>();
        _textBananaQuantity = GameObject.Find("BananaText").GetComponent<TextMeshProUGUI>();
        _textPearQuantity = GameObject.Find("PearText").GetComponent<TextMeshProUGUI>();
        _textAppleQuantity = GameObject.Find("AppleText").GetComponent<TextMeshProUGUI>();
        _textOrangeJuiceQuantity = GameObject.Find("OrangeJuiceText").GetComponent<TextMeshProUGUI>();
        _textChocolateQuantity = GameObject.Find("ChocolateText").GetComponent<TextMeshProUGUI>();
        _textCoffeeQuantity = GameObject.Find("CoffeeText").GetComponent<TextMeshProUGUI>();
        _textMilkQuantity = GameObject.Find("MilkText").GetComponent<TextMeshProUGUI>();
        _textWineQuantity = GameObject.Find("WineText").GetComponent<TextMeshProUGUI>();
    }

    
}
