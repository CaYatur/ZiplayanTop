using UnityEngine;

public class Ball : MonoBehaviour
{
	public Rigidbody2D rb;

	public float jumpPower;

	public string currentColor;

	public SpriteRenderer sr;

	public Sprite[] ballSprite;

	private GameManager gm;

	private void Start()
	{
		gm = Object.FindObjectOfType<GameManager>();
		randomball(5);
	}

	public void randomball(int _index)
	{
		switch (_index)
		{
		case 0:
			currentColor = "red";
			sr.sprite = ballSprite[0];
			base.gameObject.tag = "red";
			break;
		case 1:
			currentColor = "mor";
			sr.sprite = ballSprite[1];
			base.gameObject.tag = "mor";
			break;
		case 2:
			currentColor = "mavi";
			sr.sprite = ballSprite[2];
			base.gameObject.tag = "mavi";
			break;
		case 3:
			currentColor = "sari";
			sr.sprite = ballSprite[3];
			base.gameObject.tag = "sari";
			break;
		case 4:
			currentColor = "turuncu";
			sr.sprite = ballSprite[4];
			base.gameObject.tag = "turuncu";
			break;
		case 5:
			currentColor = "yesil";
			sr.sprite = ballSprite[5];
			base.gameObject.tag = "yesil";
			break;
		}
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		rb.velocity = Vector3.up * jumpPower;
		if (collision.gameObject.tag != currentColor)
		{
			Debug.Log("Oyun Bitti");
			gm.restartGame();
		}
		else
		{
			gm.score++;
			int index = Random.Range(0, 6);
			randomball(index);
		}
	}
}
