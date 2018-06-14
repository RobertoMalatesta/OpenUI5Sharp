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
			public static partial class model
			{
				[External]
				[Namespace(false)]
				public partial class TreeBindingCompatibilityAdapter
				{
					#region Constructor

					/// <summary>
					/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls.
					/// 
					/// This module is only for experimental and internal use!
					/// </summary>
					public extern TreeBindingCompatibilityAdapter();

					#endregion

				}
			}
		}
	}
}
