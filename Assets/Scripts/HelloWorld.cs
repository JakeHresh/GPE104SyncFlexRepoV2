using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (false)
        {
            Debug.Log("Expression is true");
        }
        else if (3 == 2)
        {
            Debug.Log("Two is equal to two");
        }
        else
        {
            Debug.Log("Two plus two equals five");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!!! Yay!!");
    }
}
