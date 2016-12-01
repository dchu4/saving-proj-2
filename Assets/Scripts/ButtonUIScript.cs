using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Vuforia{

	public class ButtonUIScript : MonoBehaviour, ITrackableEventHandler {

		#region PRIVATE_MEMBER_VARIABLES

		private TrackableBehaviour mTrackableBehaviour;

		#endregion // PRIVATE_MEMBER_VARIABLES

		public GameObject livesText;
		public GameObject thirdLife;
		public GameObject secondLife;
		public GameObject firstLife;

		#region UNTIY_MONOBEHAVIOUR_METHODS

		void Start()
		{
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}
		}

		#endregion // UNTIY_MONOBEHAVIOUR_METHODS



		#region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				livesText.SetActive (true);
				if (thirdLife != null) {
					thirdLife.SetActive (true);
				}
				if (secondLife != null) {
					secondLife.SetActive (true);
				}
				if (firstLife != null) {
					firstLife.SetActive (true);
				}
			}
			else
			{
				livesText.SetActive (false);
				if (thirdLife != null) {
					thirdLife.SetActive (false);
				}
				if (secondLife != null) {
					secondLife.SetActive (false);
				}
				if (firstLife != null) {
					firstLife.SetActive (false);
				}
			}
		}

		#endregion
	}
}