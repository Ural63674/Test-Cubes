using System.Collections;
using UnityEngine;

public class CubeEmitter : MonoBehaviour
{
    [SerializeField] private SpawnManagerScriptableObject SpawnManagerScriptableObject;
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Transform cubeEmitter;
    
    private void Start()
    {
        StartCoroutine(ILaunchNextCube());
    }

    private IEnumerator ILaunchNextCube()
    {
        yield return new WaitForSeconds(SpawnManagerScriptableObject.timeToNextCube);
        GameObject _cube = Instantiate(cubePrefab, cubeEmitter.position, Quaternion.identity);

        StartCoroutine(ILaunchNextCube());

    }
}
