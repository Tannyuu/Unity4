using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //RaycastHit hit;//RaycastHit構造体型 渡すときは初期値0　使う時に値が入る

            /*
            if (Physics.Raycast(ray, out hit, 100f))//out 参照渡し 第二引数にぶつかった物が書き込まれる　true false 第三引数は距離
            {
                Destroy(hit.collider.gameObject);
            }
            
            
              foreach(RaycastHit  hit in Physics.RaycastAll(ray)) {
               Destroy(hit.collider.gameObject);
              }
            
            */
              foreach (RaycastHit hit in Physics.SphereCastAll(ray,3f)) {
               Destroy(hit.collider.gameObject);
              }
            
        }
    }
}