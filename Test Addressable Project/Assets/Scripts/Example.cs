using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AddressableAssets;

public class Example : MonoBehaviour
{
    public AssetReference assetReference;

    void Start()
    {
        assetReference.InstantiateAsync();
    }
}
