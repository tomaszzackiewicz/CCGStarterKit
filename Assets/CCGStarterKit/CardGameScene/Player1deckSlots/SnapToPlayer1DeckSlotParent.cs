using UnityEngine;
using System.Collections;

public class SnapToPlayer1DeckSlotParent : MonoBehaviour {

	public float moveSpeed = 40.0f;
    public float rotateSpeed = 90.0f;
    protected float closeVPDist = 0.1f;
	protected float dist = 0.010f;
    protected Color closeColor = new Color(1,0,0,0.2f);
    protected Color normalColor;
    protected GameObject partnerGo;
}
