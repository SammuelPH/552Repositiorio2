using System.Collections;
using System.Collections.Generic;

public class Problema1 : MonoBehaviour
{
    public List<int[] input;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            int[] test1 = NumbersLessThan(input);
            foreach (int n in test1)
            {
                debug.Log(n);
            }
        }
    } 

    private int[] NumbersLessThan(int[] numbers)
    {
        int[] result = new int [numbers.Length];
        result[0] = 1;
        result[1] = 2;
        return result
    }
}
