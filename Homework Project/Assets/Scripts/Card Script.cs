using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class CardScript : MonoBehaviour

{
    public int numberchange= 5;
    public Color colorchange=Color.black;
    public Image backgroundcolor;

    public TMP_Text textchange;

    public int endchange= 0;

    public int addten=10;

    
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log ("Your current number is "  + numberchange);
      Addnumber(5);
      Debug.Log("Your current number is" + numberchange);
      Debug.Log ("Your current number is" + numberchange);
      Decreasenumber(5);
      Debug.Log ("Your current number is" + numberchange);
      zerochange(0);
      Debug.Log ("Your current number is" + numberchange);
      tenplus(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Addnumber(int number)
    {
    numberchange=number+numberchange;
    Debug.Log("Your number is");
    Debug.Log ("Your number is" + numberchange); 

    }

    public void Decreasenumber (int number)
    {
        numberchange=numberchange-number;
        Debug.Log("Your number is");
    Debug.Log ("Your number is" + numberchange); 
    }

public void zerochange (int number)
{
    Debug.Log("Your number is");
    Debug.Log ("Your number is" + endchange);
}

public void tenplus (int number)
{
    Debug.Log("Your number is");
    Debug.Log("Your number is" + addten);
}

    public void change ()
    {
        backgroundcolor.color=colorchange;
    }
}
