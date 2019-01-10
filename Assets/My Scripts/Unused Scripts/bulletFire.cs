using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour {

public GameObject bullet;
public GameObject[] bulletStock;
public int bulletLimit = 5;
public Transform bulletFireLocation;

    void Start()
    {
        bulletStock = new GameObject[bulletLimit];
        for (int x = 0; x < bulletLimit; x++) {
            bulletStock[x] = Instantiate(bullet);
            bulletStock[x].SetActive(false);
        }
    }

    void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
            GameObject bullet = RespawnBullet();
            if (bullet != null) {
                bullet.SetActive(true);
                bullet.transform.position = transform.position;
            }
		}
	}

    private GameObject RespawnBullet() {
        for (int y = 0; y < bulletLimit; y++)
        {
            if (!bulletStock[y].activeSelf) {
                return bulletStock[y];
            }
        }
        return null;
    }
}
