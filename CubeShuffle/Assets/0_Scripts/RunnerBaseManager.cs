using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Runner character functionality.
///
/// Takes care of:
///     - registering player inputs
///     - movement of the character
///     - increase and decrease numbers of cubes according to characters interaction
/// <summary>
public abstract class RunnerBaseManager : MonoBehaviour
{
    [SerializeField] protected static List<GameObject> cubes;
    protected new Rigidbody rigidbody;
    protected Animator animator;

    [SerializeField] protected float movementSpeed;

    private void Start() 
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    protected void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal, 0, movementSpeed * Time.deltaTime);
    }

    protected abstract void IncreaseCubeNumber();
    protected abstract void DecreaseCubeNumber();


}
