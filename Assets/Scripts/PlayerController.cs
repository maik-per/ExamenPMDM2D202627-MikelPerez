using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public CheckGround checkGround;
    public bool isRunning;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        /* Sabiendo la función de este método
        genere las instrucciones necesarias...
        */

    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        
    }

    private void checkMove()
    {
        /* Genere el código para que el jugador se mueva...
        añada las animaciones pertinentes
        */

    }    
    
    private void checkJump()
    {
        /* Genere el código para que el jugador salte...
        añada las animaciones pertinentes
        */
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}
