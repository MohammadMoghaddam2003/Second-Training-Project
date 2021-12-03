using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject knife;
    public Transform firePlace , target;


    void Update()
    {
      Fire();

    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
           GameObject Knife = Instantiate(knife,new Vector3(firePlace.position.x,firePlace.position.y,0),Quaternion.identity);
           Knife.GetComponent<Rigidbody2D>().AddForce((target.position - transform.position)* 1000 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D Coin) 
    {
        if (Coin.CompareTag("Coin"))
        {
          Destroy(Coin.gameObject);
          CoinsManager.Coin++;
        }
    }
}
