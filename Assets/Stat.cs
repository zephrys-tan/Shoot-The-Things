using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
	[SerializeField]
	private BarScript bar;

	[SerializeField]
	private AmmoScript ammo;

	[SerializeField]
	private float maxVal;

	[SerializeField]
	private float currentVal;

	[SerializeField]
	private float currentAmmo;

	public float CurrentVal
	{
		get 
		{
			return currentVal;
		}

		set 
		{
			this.currentVal = Mathf.Clamp(value, 0, MaxVal);
			bar.Value = currentVal;
		}
	}

	public float MaxVal
	{
		get 
		{
			return maxVal;
		}

		set 
		{
			this.maxVal = value;
			bar.MaxValue = maxVal;
		}
	}

	public float CurrentAmmo
	{
		get 
		{
			return currentAmmo;
		}

		set 
		{
			this.currentAmmo = value;
			ammo.Value = currentAmmo;
		}
	}

	public void Initialize()
	{
		this.MaxVal = maxVal;
		this.CurrentVal = currentVal;
		this.CurrentAmmo = currentAmmo;
	}
}
