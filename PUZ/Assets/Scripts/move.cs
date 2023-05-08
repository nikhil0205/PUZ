using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

public float speed;
Vector3 Vec;
// Start is called before the first frame update
void Start()
{

}



// Update is called once per frame
void Update()
{
Vec = transform.localPosition;
//Vec.y += Input.GetAxis("Jump") * Time.deltaTime * speed;
Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * speed;
transform.localPosition = Vec;
}
}