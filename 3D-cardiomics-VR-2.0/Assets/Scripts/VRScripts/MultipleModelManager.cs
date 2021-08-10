using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleModelManager : MonoBehaviour
{
	public Dropdown dropdown;
	private int copyCount = 1;

	public void ChangeCopyCount()
	{
		if (dropdown.value == 0) copyCount = 1; else
        {
			copyCount = dropdown.value;
        }

		// TBD if combined view active → insert additional hearts or remove
		// if not active just change amount and wait for combined view button to be pressed

	}

}
