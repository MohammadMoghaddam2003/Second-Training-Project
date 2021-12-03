using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public GameObject coin;


   void OnTriggerEnter2D(Collider2D knife) 
   {
        if (knife.CompareTag("Knife"))
        {
            Destroy(knife.gameObject);
            Destroy(gameObject);
            Instantiate(coin,transform.position,Quaternion.identity);
        } 
  } 
}
