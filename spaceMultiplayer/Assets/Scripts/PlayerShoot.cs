using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : NetworkBehaviour {
    public PlayerWeapon weapon;

    [SerializeField]
    private Camera cam;

    private void Start()
    {
        if(cam == null)
        {
            Debug.LogError("PlayerShoot: No camera referenced!");
            this.enabled = false;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {

    }
}
