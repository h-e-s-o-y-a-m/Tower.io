using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    private CubePos nowCube = new CubePos(0, 1, 0);
    public float cubeChangePlaceSpeed = 0.5f;

    private List<Vector3> allCubesPositions = new List<Vector3>{
        new Vector3(0, 0, 0),
        new Vector3(1, 0, 0),
        new Vector3(-1, 0, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, 0, 1),
        new Vector3(0, 0, -1),
        new Vector3(1, 0, 1),
        new Vector3(-1, 0, -1),
        new Vector3(-1, 0, 1),
        new Vector3(1, 0, -1),
    };

    private void Start() {
        StartCoroutine(ShowCubePlace());
    }

    IEnumerator ShowCubePlace() {
        while (true) {
            SpawnPositions();

            yield return new WaitForSeconds(cubeChangePlaceSpeed);
        }
    }

    private void SpawnPositions() {
        List<Vector3> positions = new List<Vector3>();
        if (IsPositionsEmpty(new Vector3(nowCube.x + 1, nowCube.y, nowCube.z)) {
            positions.Add(new Vector3(nowCube.x + 1, nowCube.y, nowCube.z));
        }
    
    
    }

    private bool IsPositionsEmpty(Vector3 pos) {

    }

}

struct CubePos {
    public int x, y, z;

    public CubePos(int x, int y, int z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 GetVector() {
        return new Vector3(x, y, z);
    }

    public void SetVector(Vector3 pos) {
        x = Convert.ToInt32(pos.x);
        y = Convert.ToInt32(pos.y);
        z = Convert.ToInt32(pos.z);
    }

}
