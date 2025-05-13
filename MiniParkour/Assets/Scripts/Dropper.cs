using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float droppingtime = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;



    }


    void Update()
    {
        if (Time.time > droppingtime)
        {
            
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;


        }
        
    }
}
