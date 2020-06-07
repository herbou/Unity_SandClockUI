using UnityEngine;

public class Demo : MonoBehaviour
{
	[SerializeField] SandClock clock;

	void Start ()
	{
		clock.onRoundStart += OnRoundStart;
		clock.onRoundEnd += OnRoundEnd;
		clock.onAllRoundsCompleted += OnAllRoundsCompleted;

		clock.Begin ();
	}

	void OnRoundStart (int round)
	{
		Debug.Log ("Round Start " + round);
	}

	void OnRoundEnd (int round)
	{
		Debug.Log ("Round End " + round);
	}

	void OnAllRoundsCompleted ()
	{
		Debug.Log ("......Time is over...........");
	}

	void OnDestroy ()
	{
		clock.onRoundStart -= OnRoundStart;
		clock.onRoundEnd -= OnRoundEnd;
		clock.onAllRoundsCompleted -= OnAllRoundsCompleted;
	}
}
