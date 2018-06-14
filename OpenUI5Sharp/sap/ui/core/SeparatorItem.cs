﻿using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// An item that provides a visual separation. It borrows all its methods from the classes sap.ui.core.Item, sap.ui.core.Element, sap.ui.base.EventProvider, and sap.ui.base.Object.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class SeparatorItem : sap.ui.core.Item
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Item.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SeparatorItem.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SeparatorItem(string sId, sap.ui.core.SeparatorItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new SeparatorItem.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern SeparatorItem(string sId);

					/// <summary>
					/// Constructor for a new SeparatorItem.
					/// </summary>
					public extern SeparatorItem();

					/// <summary>
					/// Constructor for a new SeparatorItem.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SeparatorItem(sap.ui.core.SeparatorItem.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.SeparatorItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.SeparatorItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.SeparatorItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.SeparatorItem.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
