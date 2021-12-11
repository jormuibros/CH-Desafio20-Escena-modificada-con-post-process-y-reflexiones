using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallTrap : MonoBehaviour
{
    [SerializeField] private float distanRay = 10f;
    [SerializeField] private GameObject shootOrigin;
    [SerializeField] private int shootCooldown = 2;
    [SerializeField] private float timeShoot =2;
    private bool canShoot = true;
    [SerializeField] private GameObject SpearPrefab;

    [SerializeField]  private bool  isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        { 
            if(canShoot)
            {
             RaycastTrap();
            }
            else
            {
                timeShoot += Time.deltaTime;
            }
            if(timeShoot > shootCooldown)
            {
                canShoot =true;
            }
        }
        
    }
    private void RaycastTrap()
    {
        RaycastHit hit;
        if(Physics.Raycast(shootOrigin.transform.position, shootOrigin.transform.TransformDirection(Vector3.forward), out hit, distanRay))
        {
            Debug.Log("GOLPEO");
            if(hit.transform.tag == "Player")
            {
            timeShoot = 0;
            canShoot = false;
            GameObject b = Instantiate(SpearPrefab, shootOrigin.transform.position, SpearPrefab.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(shootOrigin.transform.TransformDirection(Vector3.forward)*10f,ForceMode.Impulse);
            }
        }
    }
    private void OnDrawGizmos()
    {
        if (canShoot && isActive){
        Gizmos.color = Color.red;
        Gizmos.DrawRay(shootOrigin.transform.position, Vector3.left * distanRay);
        }

    }

    public void SetActiveWallTrap(bool status)
    {
        isActive = status;
    }
}

