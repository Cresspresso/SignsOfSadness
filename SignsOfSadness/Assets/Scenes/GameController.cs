using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Slider pointsSlider;
	public float fallHalfWidth;
    public bool isGameInProgress = true;
    public GameObject GoodTextPrefab;
    public GameObject BadTextPrefab;
    public Transform TextParent;

    private static readonly string[] goodWords = new string[] {

    };

    void Start ()
	{
		pointsSlider.value = pointsSlider.minValue;

		Camera.main.transform.position = new Vector2(0, Camera.main.orthographicSize / 2);

		var w = Camera.main.orthographicSize * Camera.main.aspect;
		fallHalfWidth = w / 2 - 0.3f;

		var player = FindObjectOfType<Player>();
		player.limits.xMax = fallHalfWidth;
		player.limits.xMin = -fallHalfWidth;

        StartCoroutine(WordSpawner());
	}

	public void OnPickingUp(Pickup pickup)
	{
		Destroy(pickup.gameObject);
		Debug.Log("Picked up " + pickup.name);
		Debug.Log("Word is " + pickup.GetComponent<Text>().text);
		switch (pickup.tag)
		{
			case "Good":
				Debug.Log("Word is considered good.");
				pointsSlider.value += 1;
				break;
			case "Bad":
				Debug.Log("Word is considered bad.");
				pointsSlider.value -= 1;
				break;
			default:
				break;
		}

        if (pointsSlider.value == pointsSlider.maxValue)
        {
            Debug.Log("Finished!");
        }
	}

    IEnumerator WordSpawner()
    {
        while (isGameInProgress)
        {
            var go = Instantiate(GoodTextPrefab, TextParent, false);
            go.transform.localPosition = new Vector3(Random.Range(-200, 200), 900, 0);
            go.name = GoodTextPrefab.name + " instantiated";
            yield return new WaitForSeconds(1.0f);
        }
    }
}
