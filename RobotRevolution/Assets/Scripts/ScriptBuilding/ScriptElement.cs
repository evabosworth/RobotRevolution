using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

public abstract class ScriptElement {
	private List<ScriptElement> beforeElements = new List<ScriptElement>();
	private List<ScriptElement> afterElements = new List<ScriptElement>();
	private ScriptElementRequiredStatus elementRequiredStatus = ScriptElementRequiredStatus.START;

	/**
	 * getScriptRequiredStatus 
	 * return ScriptElementRequiredStatus, denotes if an element is required
	 */
	public ScriptElementRequiredStatus getScriptRequiredStatus(){
		return elementRequiredStatus;
	}

	public List<ScriptElement> getBeforeElements(){
		return beforeElements;
	}

	public List<ScriptElement> getAfterElements(){
		return afterElements;
	}

	//Needs to not be object, second one will be params, such as select allies and such
	public abstract List<Object> getAllElementOptions(List<Object> parameters);
}
