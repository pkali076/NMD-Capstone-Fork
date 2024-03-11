using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGen : MonoBehaviour {
    public GameObject cube;

    // Start is called before the first frame update
    void Start() {
        Vector3 start = new Vector3(-12, 6, 2);
        for (int i = 0; i < 30; i++) {
            for (int j = 0; j < 20; j++) {
                GameObject newCube = Instantiate(cube, start + new Vector3(i, -j, 4), Quaternion.identity);
                newCube.transform.SetParent(transform, true);  
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }
}