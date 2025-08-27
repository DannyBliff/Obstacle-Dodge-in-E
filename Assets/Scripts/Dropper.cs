using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3f;

    MeshRenderer _meshRenderer;
    Rigidbody _rigidbody;
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        
        _rigidbody.useGravity = false;
        _meshRenderer.enabled = false;
    }
    void Update()
    {
        if (Time.time > dropTime)
        {
            Debug.Log("Lookout Below!");
            
            _rigidbody.useGravity = true;
            _meshRenderer.enabled = true;
        }
    }
}
