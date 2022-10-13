using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Vector3 speed;
    [SerializeField] private SpawnManagerScriptableObject spawnManagerScriptableObject;

    private void Awake()
    {
        speed = new Vector3(0, 0, spawnManagerScriptableObject.cubeSpeed);
    }
    void Update()
    {
        //if(gameObject != null)
        //{
            transform.Translate(speed * Time.deltaTime);

            if (transform.position.z > spawnManagerScriptableObject.cubeDistance)
            {
                Destroy(gameObject);
            }
        //}       
    }
}
