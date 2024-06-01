using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram3 : MonoBehaviour
{

    private void Start()
    {
   
        calculateTwoNumbers();
        calculate2Numbers(12, 8);
        // Debug.Log("The sum is " + ReturnTwoNumbers());
        Debug.Log("The sum A + B is: " + ReturnTwoNumbers(19, 10));
        
    }
        
    // Tanpa paramater
    // Void itu nandain function doesnt return anything
    void calculateTwoNumbers()
    {

        float a = 10;
        float b = 5;
        float c = a + b;

        Debug.Log("The sum of A + B = " + c);

    }

    // Pakek parameter
    void calculate2Numbers(float a, float b)
    {
        Debug.Log("The sum of A + B is: " + (a + b));
    }

    // Function yg return the value
    float ReturnTwoNumbers()
    {
        return 17 + 31;
    }

    // Nama function bs sama asalkan paramaternya beda
    float ReturnTwoNumbers(float a , float b)
    {
        return a + b;
    }

}
