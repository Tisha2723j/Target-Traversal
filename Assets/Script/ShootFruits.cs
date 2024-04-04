using UnityEngine;

public class ShootFruits : MonoBehaviour
{
    public float shootForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Assuming left mouse button for shooting
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Rigidbody fruitRb = hit.transform.GetComponent<Rigidbody>();
                if (fruitRb != null)
                {
                    Vector3 direction = hit.point - transform.position;
                    fruitRb.AddForce(direction.normalized * shootForce, ForceMode.Impulse);
                }
            }
        }
    }
}