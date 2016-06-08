using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ScenesParameters {
	private static Dictionary<string, int> parameters;

	public static int GetParameter(string paramKey) {
		if (parameters == null) return 0;
		return parameters[paramKey];
	}

	public static void SetParameter(string paramKey, int paramValue) {
		if (parameters == null) {
			ScenesParameters.parameters = new Dictionary<string, int> ();
		}

		ScenesParameters.parameters.Remove (paramKey);
		ScenesParameters.parameters.Add(paramKey, paramValue);
	}

	public static void Clear() {
		if (parameters != null) {
			parameters.Clear ();
		}
	}
}
