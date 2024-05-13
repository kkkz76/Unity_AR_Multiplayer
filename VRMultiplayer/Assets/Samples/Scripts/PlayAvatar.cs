using Fusion;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class PlayAvatar : NetworkBehaviour
{
    private void Start()
    {
        if (Object.HasInputAuthority)
        {
            XROrigin xrOrigin = FindObjectOfType<XROrigin>();
            xrOrigin.transform.position = transform.position;
            transform.parent = xrOrigin.transform;
        }
    }
}
