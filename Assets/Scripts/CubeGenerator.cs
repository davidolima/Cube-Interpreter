using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    void Start()
    {
        for (int x = 0; x < 3; x++){
            for (int y = 0; y < 3; y++){
                for (int z = 0; z < 3; z++){
                    Debug.Log((x,y,z));
                    new Cubie(x,y,z);
                }
            }
        }
    }
}
