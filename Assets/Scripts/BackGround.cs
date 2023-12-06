using UnityEngine;
public class BackGround : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        if (gameObject.transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
    
}
