using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikerController : MonoBehaviour
{
    [SerializeField] float StrikerSpeed,extraSpeed,maxSpeed;
    Rigidbody2D rb;
    private float xDirection, yDirection;
    public LowerBoundryScripts scripts;
    public ScoreController scoreController;

    private int hitCount = 0;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        hitCount = 0;
        yield return new WaitForSeconds(1);
        MoveBall();
    }


    public void MoveBall()
    {
        if(Random.Range(0,2) == 0) { xDirection = -1; }
        else { xDirection = 1; }

        if (Random.Range(0, 2) == 0) { yDirection = -1; }
        else { yDirection = 1; }

        float ballSpeed = StrikerSpeed + hitCount * extraSpeed;
        rb.velocity = new Vector2(ballSpeed * xDirection, ballSpeed * yDirection);
    
    }

    public void HitIncrementor()
    {
        if(hitCount * extraSpeed < maxSpeed)
        {
            hitCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LowerBoundry")
        {
            hitCount++;
        }
    }

}
