using UnityEngine;

public class weaponNewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.RotateAround(Vector3.zero, Vector3.forward, 200*Time.deltaTime);    
    }
}
