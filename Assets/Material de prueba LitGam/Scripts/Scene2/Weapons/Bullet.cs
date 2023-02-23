using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    void Update() {
        
        StartCoroutine(DestroyBullet());
    }

    IEnumerator DestroyBullet()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
    }
}
