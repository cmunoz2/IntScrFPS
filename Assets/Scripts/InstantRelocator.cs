// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InstantRelocator : MonoBehaviour, IItem
// {
//     public GameObject reloPoint;

//     private Rigidbody rb;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rb= this.GetComponent<Rigidbody>(); 
//         reloPoint = GameObject.FindWithTag("ReloPoint");
        
//     }

//     public void Use()
//     {
//         Debug.Log("MOUSECLICK 0");
//         rb.transform.position = reloPoint.transform.position;  
//     }

//     public void AltUse()
//     {
//         Debug.Log("MoUsEClICk 1");
//         ThrowRelocationPoint(reloPoint);
//     }
    

//     public void Pickup(Transform hand) 
//     {
//         Debug.Log("I am picked up!");
// 		this.transform.SetParent(hand);
// 		this.transform.localPosition = Vector3.zero;
// 		this.transform.localRotation = Quaternion.identity;
// 		rb.isKinematic = true;
// 		Destroy(this.GetComponent<SpinItem>());	
// 	}

// 	public void Drop() 
//     {
// 		Debug.Log("Dropping heldItem");
// 		this.transform.SetParent(null);
// 		// throw item
// 		rb.isKinematic = false;
// 		rb.AddRelativeForce(Vector3.forward * 5, ForceMode.Impulse);
// 	}

//     void ThrowRelocationPoint (GameObject relocator)
//     {
//         RaycastHit hit;
//             if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)){
//                 Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward *20), Color.green);
//                 if(hit.transform.gameObject.CompareTag("ReloWall")){
//                    Debug.Log("Hit Relocator Wall");
//                    Rigidbody rb = Instantiate(reloPoint, reloPoint.position, reloPoint.rotation);
                    
//                 }
//                 else{
//                     Debug.Log("Miss");
//                 }
//             }
//     }
// }
