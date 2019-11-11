using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Contact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

        }

        // Update is called once per frame
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
