using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : NetworkBehaviour {
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
}
