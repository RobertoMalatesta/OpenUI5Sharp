﻿using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			public static partial class semantic
			{
				/// <summary>
				/// A semantic-specific button, eligible for the <code>closeAction</code> aggregation of the {@link sap.f.semantic.SemanticPage} to be placed in its title.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.f.semantic.CloseAction")]
				public partial class CloseAction : sap.f.semantic.SemanticButton
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.f.semantic.SemanticButton.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>CloseAction</code>.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern CloseAction(string sId, sap.f.semantic.CloseAction.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>CloseAction</code>.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern CloseAction(string sId);

					/// <summary>
					/// Constructor for a new <code>CloseAction</code>.
					/// </summary>
					public extern CloseAction();

					/// <summary>
					/// Constructor for a new <code>CloseAction</code>.
					/// </summary>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern CloseAction(sap.f.semantic.CloseAction.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.CloseAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.CloseAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.CloseAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.f.semantic.CloseAction.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
