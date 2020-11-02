using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("Meer dan 1 BuildManager");
			return;
		}
		instance = this;
	}
	private GameObject turretToBuild;
	private Node selectedNode;
	public GameObject standardTurretPrefab;
	public GameObject RocketTurretPrefab;
	public void DeselectNode()
	{
		selectedNode = null;
	}

	public GameObject GetTurretToBuild ()
	{
		return turretToBuild;
	}
	public void SetTurretToBuild (GameObject turret)
	{
		turretToBuild = turret;
	}
}