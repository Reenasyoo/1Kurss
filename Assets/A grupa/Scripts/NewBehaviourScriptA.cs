using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScriptA : MonoBehaviour
{
    // Variables / vērtības
    public int a = 0; // 1,2,3 -1,2,3 
    public int aaa = 2;
    private float b = 0f; // 1.4, 6.9, 4.2,
    private string d = "afsda";
    protected bool c = false; // true, false
    // + - * / () 

    public InputField inputText;
    public Text outputText;
    public Text strenghtText;
    public string chacheString;
    public int strenght = 0;
    public int pointCount =0;


    private void Start()
    {
        // print("hello");
        // print(a);
        // print(ReturnIntPrivate());
        // Math();
        FuncWithParam(5);
    }

    public void SetOutputText()
    {
        pointCount = int.Parse(inputText.text);
    }

    public void DisplayNewText()
    {
        outputText.text = chacheString;
    }

    public void AddStrenght()
    {
        // strenght++; // strenght+1
        // strenght += 2;
        strenght += pointCount;
        UpdateStrenghtText();
    }

    public void UpdateStrenghtText()
    {
        strenghtText.text = strenght.ToString();
    }

    public void RemoveStrenght()
    {
        // strenght--;
        strenght -= pointCount;
        UpdateStrenghtText();
    }


    public void Math()
    {
        int c = a + aaa;
        print(c);
    }
    public void FuncWithParam(int param)
    {
        print(param);
    }
    private float ReturnIntPrivate()
    {
        int returnInt = 0;
        return returnInt;
    }
    public float ReturnIntPublic()
    {
        return a;
    }


    public int Bar(int param)
    {
        int c = 3 + param;
        return c;
    }

    public void Foo()
    {
        print(Bar(5));
    }
}

 /*
            0+1 = 1
            ! RIGHT !
            strenght = strenght + 1; 
            strenght =+ 1; 
            strenght += 1; 
            strenght++;

            ! WRONG !
            strenght = strenght +2;
            strenght =+ 2;
        */