using UnityEngine;
using UnityEngine.TestTools;

namespace OpenFracture.Runtime.Scripts.Support
{
    [ExcludeFromCoverage]
    public class Projectile : MonoBehaviour
    {
        public GameObject projectile;
        public float initialVelocity;
        public KeyCode FireKey;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(FireKey))
            {
                // Remove other projectiles from the scene
                foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Projectile"))
                {
                    GameObject.Destroy(obj);
                }

                var projectileInstance = GameObject.Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectileInstance.GetComponent<Rigidbody>().velocity = initialVelocity * this.transform.forward;
            }
        }
    }
}
