using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    
    #region[ATRIBUTOS UI] 
    public float speed;
    public float jump;
    public bool isJumping;
    public bool isEndlessRun;
    public bool isSideView;
    public bool isNormal2D;

    public bool Levitar;
    public bool intangivel;
    #endregion

    #region[ATRIBUTOS PRIVADOS]
    private float Move;
    private float MoveHorizontal;
    private float MoveVertical;
    private Rigidbody2D rb;
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (isSideView)
        {
            rb.gravityScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
    }

    private void Movimentacao(){

        if (isEndlessRun)
        {
            EndlessRun();
        }
        else if(isNormal2D)
        {
            Normal2D();
        }
        else if (isSideView)
        {
            SideView();
        }
    }

    private void SideView()
    {
        MoveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * MoveHorizontal, rb.velocity.y);


        MoveVertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, speed * MoveVertical);

        if (Input.GetKeyDown("space"))
        {
            rb.MoveRotation(0);
            rb.SetRotation(0);
        }

        SkillIntangivel();
    }

    private void EndlessRun()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping) ///adaptar isso aqui
            rb.AddForce(new Vector2(rb.velocity.x, jump));
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground") && isNormal2D)
            isJumping = false;
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground") && isNormal2D)
            isJumping = true;
    }

    private void SkillIntangivel()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var PlayerCollider = this.gameObject.GetComponent<BoxCollider2D>();
            PlayerCollider.enabled = !PlayerCollider.enabled;
            //intangivel = !intangivel;
        }

        if (intangivel)
        {
            var PlayerCollider = this.gameObject.GetComponent<BoxCollider2D>();
            PlayerCollider.enabled = !PlayerCollider.enabled;
        }
    }

    private void Normal2D()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (/*Levitar &&*/ Input.GetButtonDown("Jump") && !isJumping)
            rb.AddForce(new Vector2(rb.velocity.x, jump));

        SkillIntangivel();
    }

    
}
