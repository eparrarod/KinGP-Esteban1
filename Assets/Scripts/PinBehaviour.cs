using UnityEngine;

public class PinBehaviour : MonoBehaviour{
    public float speed = 2.0f;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    Camera cam;
    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate(){
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed* Time.fixedDeltaTime);
        body.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(this + " collided with " + collision.gameObject.name);
        string tag = collision.gameObject.tag;
        if (tag == "wall" || tag == "ball") {
            Debug.Log(" Game Over ");
        }
    }
}