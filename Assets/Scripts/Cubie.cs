using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubie : MonoBehaviour{
    int x;
    int y;
    int z;
    public Cubie(int x, int y, int z){
        x = 0;
        y = 0;
        z = 0;
    }

    public void Awake(){
        GameObject Box = new GameObject();
        Box.transform.position.Set(x,y,z);
    }
}
