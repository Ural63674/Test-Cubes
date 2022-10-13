using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    [Range (0.0f, 10.0f)]
    public float cubeSpeed;

    [Range(0.0f, 10.0f)]
    public float cubeDistance;

    [Range(0.0f, 10.0f)]
    public float timeToNextCube;
}
