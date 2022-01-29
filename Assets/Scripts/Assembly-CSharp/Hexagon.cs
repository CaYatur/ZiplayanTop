using System.Collections;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		StartCoroutine(Rotate());
	}

	private IEnumerator Rotate()
	{
		Vector3 vector = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, base.transform.position.y, base.transform.position.z));
		if (Input.GetMouseButtonDown(0) && vector.x < 0f)
		{
			base.transform.Rotate(0f, 0f, 20f);
			yield return new WaitForSeconds(0.05f);
			base.transform.Rotate(0f, 0f, 20f);
			yield return new WaitForSeconds(0.05f);
			base.transform.Rotate(0f, 0f, 20f);
		}
		else if (Input.GetMouseButtonDown(0) && vector.x > 0f)
		{
			base.transform.Rotate(0f, 0f, -20f);
			yield return new WaitForSeconds(0.05f);
			base.transform.Rotate(0f, 0f, -20f);
			yield return new WaitForSeconds(0.05f);
			base.transform.Rotate(0f, 0f, -20f);
		}
		yield return null;
	}
}
