using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField]
    levector first = new levector();
    [SerializeField]
    levector second = new levector();
    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;
    
    void Start()
    {
        levector result = first + second;
        Debug.Log(result);
        levector showresta = second - first;
        Debug.Log(showresta);
    }
    void Update()
    {
        //dibuja los vectores
        first.Draw(first, Color.blue);
        second.Draw(second, Color.red);
        //dibuja la diferencia
        var resultRes = second - first;
        resultRes = resultRes * (range);
        resultRes.Draw(resultRes, Color.green);
        resultRes.Draw(first, resultRes, Color.black);
        //dibuja el lerp
        var lerpVar = first.Lerp(first, second, range);
        lerpVar.Draw(lerpVar, Color.yellow);
    }
}
