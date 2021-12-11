using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretController : MonoBehaviour
{
    [SerializeField] private float distanRay = 10f;
    [SerializeField] private int shootCooldown = 2;
    [SerializeField] private float timeShoot =2;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float direction;
    [SerializeField] private GameObject Hero;
    [SerializeField] private GameObject Flame;
    [SerializeField] private GameObject FlamePrefab;
    private float RangeOfView = 5f;
    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, Hero.transform.position) <= RangeOfView)
        {
         RaycastTrap();
         LookHero();
        }
    }
    private void RaycastTrap()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distanRay))
        {
            if(hit.transform.tag == "Player")
            {
             GameObject b = Instantiate(FlamePrefab, Flame.transform.position, FlamePrefab.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Flame.transform.TransformDirection(Vector3.right)*10f,ForceMode.Impulse);
            }
        }
    }
    private void OnDrawGizmos()
    {
       
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, RangeOfView);  
    }
    private void LookHero()
    {
     Vector3 direction =(Hero.transform.position - transform.position).normalized;
     transform.forward = Vector3.Lerp(transform.forward, direction, rotationSpeed * Time.deltaTime);
    }
}
