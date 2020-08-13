using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomModelInfo : MonoBehaviour {
	public ModelType modelType;
	public SkinnedMeshRenderer blendshapesRenderer;
	public Transform jawBone;
	public Transform[] eyes;
	public Transform[] eyeLids;
}

public enum ModelType {
	Vroid,
	AnimatedMouth,
	NoMouth
}