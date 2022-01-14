using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    //vitesse des elements de la fabrique
    public float speed = 0.5f;
    // Seuil de disparition deselements de la fabrique
    public float extinctionThreshold;
    // Start is called before the first frame update

    //A la creation on definie le seuil
    void Start()
    {
        extinctionThreshold = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    /*
     * A chaque update on deplace les elements de la fabrique.
     */
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < extinctionThreshold)
        {
            Destroy(gameObject);
        }
        
    }
}
