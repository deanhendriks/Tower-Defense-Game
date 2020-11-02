using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

  public void PurchaseStandardTurret()
  {
      Debug.Log("standard turret gekocht");
      buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
  }

  public void PurchaseRocketTurret()
  {
      Debug.Log("rocket turret gekocht");
      buildManager.SetTurretToBuild(buildManager.RocketTurretPrefab);
  }
}
