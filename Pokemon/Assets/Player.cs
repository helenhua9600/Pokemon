using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMoveAmount = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float horizontalMoveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime; 

        transform.Translate(verticalMoveAmount,horizontalMoveAmount,0);
    }
}
