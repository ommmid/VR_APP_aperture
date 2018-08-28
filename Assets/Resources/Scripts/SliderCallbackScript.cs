using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCallbackScript : MonoBehaviour {

    public GameObject objectBase;
    public GameObject objectWall4;
    public GameObject objectWall1;
    public GameObject objectWall2;
    public GameObject objectWall3;
    public GameObject objectCube;
    public Text sliderTextH;
    public Text sliderTextD;

    private Vector3 newScaleBase;
    private Vector3 newScaleWall4;
    private Vector3 newScaleWall1;
    private Vector3 newScaleWall2;
    private Vector3 newScaleWall3;

    private Vector3 newPositionWall4;
    private Vector3 newPositionBase;
    private Vector3 newPositionWall1;
    private Vector3 newPositionWall2;
    private Vector3 newPositionWall3;
    private Vector3 newPositionCube;

    public Slider sliderH;
    public Slider sliderD;
    private float sliderValueH;
    private float sliderValueD;
    private float changeY;

    // Use this for initialization
    void Start () {
        sliderH.onValueChanged.AddListener(delegate { callBackHeight(); });
        sliderD.onValueChanged.AddListener(delegate { callBackDepth(); });
    }
	
	// Update is called once per frame
	void Update () {

    }

    // Invoked when the value of the slider changes.
    public void callBackHeight()
    {
        sliderTextH.text = sliderH.value.ToString("f2");
        sliderValueH = sliderH.value * 0.2f; // the height of the base and wall4 are 0.2 and I want to have the slider go as high as 0.2

        newScaleWall4 = objectWall4.transform.localScale;
        newScaleWall4.y = sliderValueH;
        objectWall4.transform.localScale = newScaleWall4;

        newPositionWall4 = objectWall4.transform.parent.position;
        newPositionWall4.y = (sliderValueH ) / 2; 
        objectWall4.transform.parent.position = newPositionWall4;

        newScaleBase = objectBase.transform.localScale;
        newScaleBase.y = sliderValueH;
        objectBase.transform.localScale = newScaleBase;

        newPositionBase = objectBase.transform.parent.position; 
        newPositionBase.y = (sliderValueH ) / 2; 
        objectBase.transform.parent.position = newPositionBase;

        changeY = newPositionWall4.y * 2 + 0.1f;

        newPositionWall1 = objectWall1.transform.position;
        newPositionWall1.y = changeY;
        objectWall1.transform.position = newPositionWall1;

        newPositionWall2 = objectWall2.transform.position;
        newPositionWall2.y = changeY;
        objectWall2.transform.position = newPositionWall2;

        newPositionWall3 = objectWall3.transform.position;
        newPositionWall3.y = changeY + 0.1f + 0.005f;
        objectWall3.transform.position = newPositionWall3;

    }

    public void callBackDepth()
    {
        sliderTextD.text = sliderD.value.ToString("f2");
        sliderValueD = sliderD.value * 0.26f; // the depth of wall1, wall2, and wall3 are 0.13

        newScaleWall1 = objectWall1.transform.localScale;
        newScaleWall1.y = sliderValueD;
        objectWall1.transform.localScale = newScaleWall1;

        newScaleWall2 = objectWall2.transform.localScale;
        newScaleWall2.y = sliderValueD;
        objectWall2.transform.localScale = newScaleWall2;

        newScaleWall3 = objectWall3.transform.localScale;
        newScaleWall3.y = sliderValueD;
        objectWall3.transform.localScale = newScaleWall3;

        newPositionWall1 = objectWall1.transform.parent.position;
        newPositionWall1.z =  sliderValueD / 2 - 0.7f - 0.26f / 2; 
        objectWall1.transform.parent.position = newPositionWall1;

        // ----------

        newScaleWall4 = objectWall4.transform.localScale;
        newScaleWall4.z = sliderValueD;
        objectWall4.transform.localScale = newScaleWall4;

        newPositionWall4 = objectWall4.transform.parent.position;
        newPositionWall4.z = sliderValueD / 2 - 0.7f - 0.26f / 2;
        objectWall4.transform.parent.position = newPositionWall4;

        newScaleBase = objectBase.transform.localScale;
        newScaleBase.z = sliderValueD;
        objectBase.transform.localScale = newScaleBase;

        newPositionBase = objectBase.transform.parent.position;
        newPositionBase.z = newPositionWall4.z + sliderValueD ;
        objectBase.transform.parent.position = newPositionBase;


    }

}

