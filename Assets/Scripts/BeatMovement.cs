using UnityEngine;

public class BeatMovement : MonoBehaviour
{
    [SerializeField] float speed = 5; 
    [SerializeField] float lifetime = 8;
    public bool alreadyHit;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }


}
