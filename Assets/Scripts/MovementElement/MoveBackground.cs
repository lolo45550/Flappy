using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    //vitesse
    public float aimationSpeed =0.2f;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    
    /* 
     * A chaque update on decale l'objet
     */
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(aimationSpeed * Time.deltaTime, 0);
    }
}
