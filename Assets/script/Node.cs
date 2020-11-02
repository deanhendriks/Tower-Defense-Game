using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
	private GameObject turret;
	public Color hoverColor;
	private Renderer rend;
	private Color startColor;

	BuildManager buildManager;
	
    void Start ()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;

		buildManager = BuildManager.instance;
    }

	void OnMouseDown()
	{
		if (buildManager.GetTurretToBuild() == null)
			return;

		if (turret != null)
		{
			Debug.Log("Cant build here yet");
			return;
		}
		
		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
	}
	
	void OnMouseEnter ()
	{
		if (buildManager.GetTurretToBuild() == null)
			return;
			
		rend.material.color = hoverColor;
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
    }

}