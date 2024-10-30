using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("5 * " + i + " = " + Multiply(5,i));
        }
    }
    private int Multiply(int x, int y)
    {
        return x * y;
    }
}
