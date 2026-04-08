using UnityEngine;

public class NeDestroyAfterTime : MonoBehaviour
{
    public float time;
    void Start()
    {
        Destroy (gameObject, time);
    }

    
}
