using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPipe : MonoBehaviour
{
    public GameObject prefbab;

    //Seuils de vitesse, hauteur minimale et maximale
    public float repeatRate = 1f;
    public float min = -1f;
    public float max = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(FabPipe), repeatRate, repeatRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(FabPipe));
    }

    /*
     * Sert a creer les objets
     */
    private void FabPipe()
    {
        GameObject pipes = Instantiate(prefbab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(min, max);
    }
}
