using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector3 direction;

    //Variables permettant de g�rer l'animation du saut
    private SpriteRenderer animationJump;
    private int indexAnimation=0;
    public Sprite[] sprites;


    //Constante du d�lai entre chaque sprite de l'animation de saut
    static float DELAY_ANIMATION = 0.15f;
    
    //Gravit� pour g�rer la retomber de l'oiseau
    private float gravity;
    //Force pour g�rer le saut de l'oiseau
    public float strength = 5f;

    /**
     * On reset la gravit� a z�ro pour que l'oiseau ne tombe pas directement et on initialise l'animation
     */
    private void Awake()
    {
        animationJump = GetComponent<SpriteRenderer>();
        gravity = 0f;
        InvokeRepeating(nameof(AnimationBird), DELAY_ANIMATION, DELAY_ANIMATION);
    }

    /*
    * � chaque update on regarde si une touche est utilis�e ou si le t�l�phone est touch� pour g�n�rer une impulsion
    * et on effectue une translation du vecteur
     **/
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            AnimationBird();
            direction = Vector3.up * strength;
            gravity = -10f;
        }

        if (Input.touchCount > 0)
        {
            AnimationBird();
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
            gravity = -10f;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    /**
     * Animation du Jump en alternant les sprites du tableau
     **/
    private void AnimationBird()
    {
        indexAnimation++;
        if (indexAnimation >= sprites.Length)
        {
            indexAnimation = 0;
        }

        animationJump.sprite = sprites[indexAnimation];
        
    }

    /*private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
        gravity = 0f;
    }*/

    /*
     *  Permets de g�rer les collisions en fonction du tag inscrit sur les GameOject poss�dant un collider2D
     */
    private void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.tag == "Collider")
        {
            FindObjectOfType<GameManager>().birdDead();
        }
        if (o.gameObject.tag == "Score")
        {
            FindObjectOfType<Scoring>().scoring();
        }
        if (o.gameObject.tag == "Trigger2")
        {
            FindObjectOfType<ScoringLevel2>().scoring();
        }

    }

}