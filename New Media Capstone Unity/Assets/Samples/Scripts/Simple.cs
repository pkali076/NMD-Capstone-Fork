﻿using SVGMeshUnity;
using UnityEngine;

public class Simple : MonoBehaviour
{
	private static readonly string SVG_PATH =

		@"M17.316,6.246c0.008,0.162,0.011,0.326,0.011,0.488c0,4.99-3.797,10.742-10.74,10.742c-2.133,0-4.116-0.625-5.787-1.697
		c0.296,0.035,0.596,0.053,0.9,0.053c1.77,0,3.397-0.604,4.688-1.615c-1.651-0.031-3.046-1.121-3.526-2.621
		c0.23,0.043,0.467,0.066,0.71,0.066c0.345,0,0.679-0.045,0.995-0.131c-1.727-0.348-3.028-1.873-3.028-3.703c0-0.016,0-0.031,0-0.047
		c0.509,0.283,1.092,0.453,1.71,0.473c-1.013-0.678-1.68-1.832-1.68-3.143c0-0.691,0.186-1.34,0.512-1.898
		C3.942,5.498,6.725,7,9.862,7.158C9.798,6.881,9.765,6.594,9.765,6.297c0-2.084,1.689-3.773,3.774-3.773
		c1.086,0,2.067,0.457,2.756,1.191c0.859-0.17,1.667-0.484,2.397-0.916c-0.282,0.881-0.881,1.621-1.66,2.088
		c0.764-0.092,1.49-0.293,2.168-0.594C18.694,5.051,18.054,5.715,17.316,6.246z";

//        @"M10,0.4c-5.302,0-9.6,4.298-9.6,9.6s4.298,9.6,9.6,9.6s9.6-4.298,9.6-9.6S15.302,0.4,10,0.4z M13.905,8.264
//        c0.004,0.082,0.005,0.164,0.005,0.244c0,2.5-1.901,5.381-5.379,5.381c-1.068,0-2.062-0.312-2.898-0.85
//        c0.147,0.018,0.298,0.025,0.451,0.025c0.886,0,1.701-0.301,2.348-0.809c-0.827-0.016-1.525-0.562-1.766-1.312
//        c0.115,0.021,0.233,0.033,0.355,0.033c0.172,0,0.34-0.023,0.498-0.066c-0.865-0.174-1.517-0.938-1.517-1.854V9.033
//        C6.257,9.174,6.549,9.26,6.859,9.27C6.351,8.93,6.018,8.352,6.018,7.695c0-0.346,0.093-0.672,0.256-0.951
//        c0.933,1.144,2.325,1.896,3.897,1.977c-0.033-0.139-0.049-0.283-0.049-0.432c0-1.043,0.846-1.891,1.891-1.891
//        c0.543,0,1.035,0.23,1.38,0.598c0.431-0.086,0.835-0.242,1.2-0.459c-0.141,0.441-0.44,0.812-0.831,1.047
//        c0.383-0.047,0.747-0.148,1.086-0.299C14.595,7.664,14.274,7.998,13.905,8.264z";

	[SerializeField] private SVGMesh Mesh;

	private SVGData SVG;

	void Start()
	{
		SVG = new SVGData();
		SVG.Path(SVG_PATH);
		// Debug.Log(SVG.Dump());
	}

	void Update()
	{
		Mesh.Fill(SVG);
	}
}