﻿using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		/// <summary>
		/// The main UI5 control library, with responsive controls that can be used in touch devices as well as desktop browsers.
		/// </summary>
		[External]
		[Namespace(false)]
		public static partial class m
		{
			#region Typed Parameters

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class SelectInfo
			{
				/// <summary>
				/// Checks whether the CheckBox is marked or not .
				/// </summary>
				public bool selected;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class SelectionChangeInfo
			{
				/// <summary>
				/// The selected item.
				/// </summary>
				public sap.ui.core.Item selectedItem;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class PickerChangeInfo
			{
				/// <summary>
				/// The new value of the <code>sap.m.DatePicker</code> as specified by <code>valueFormat</code>.
				/// </summary>
				public string value;

				/// <summary>
				/// Indicator for a valid date.
				/// </summary>
				public bool valid;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class SubmitOrChangeInfo
			{
				/// <summary>
				/// The value of the feed input before reseting it.
				/// </summary>
				public string value;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class TilePressInfo
			{
				/// <summary>
				/// The current scope the GenericTile was in when the event occurred.
				/// </summary>
				public sap.m.GenericTileScope scope;

				/// <summary>
				/// The action that was pressed on the tile. In the Actions scope, the available actions are Press and Remove. In Display scope, the parameter value is only Press.
				/// </summary>
				public string action;

				/// <summary>
				/// The pressed DOM Element pointing to the GenericTile's DOM Element in Display scope. In Actions scope it points to the more icon, when the tile is pressed, or to the DOM Element of the remove button, when the remove button is pressed.
				/// </summary>
				public object domRef;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class AfterOpenCloseBeforeInfo
			{
				/// <summary>
				/// Refers to the control which opens the popover
				/// </summary>
				public sap.ui.core.Control openBy;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class MessageListSelectInfo
			{
				/// <summary>
				/// This parameter refers to the type of messages being shown.
				/// </summary>
				public sap.ui.core.MessageType messageTypeFilter;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class TokenChangeInfo
			{
				/// <summary>
				/// Type of tokenChange event. There are four TokenChange types: "added", "removed", "removedAll", "tokensChanged". Use Tokenizer.TokenChangeType.Added for "added", Tokenizer.TokenChangeType.Removed for "removed", Tokenizer.TokenChangeType.RemovedAll for "removedAll" and Tokenizer.TokenChangeType.TokensChanged for "tokensChanged".
				/// </summary>
				public string type;

				/// <summary>
				/// The added token or removed token. This parameter is used when tokenChange type is "added" or "removed".
				/// </summary>
				public sap.m.Token token;

				/// <summary>
				/// The array of removed tokens. This parameter is used when tokenChange type is "removedAll".
				/// </summary>
				public sap.m.Token[] tokens;

				/// <summary>
				/// The array of tokens that are added. This parameter is used when tokenChange type is "tokenChanged".
				/// </summary>
				public sap.m.Token[] addedTokens;

				/// <summary>
				/// The array of tokens that are removed. This parameter is used when tokenChange type is "tokenChanged".
				/// </summary>
				public sap.m.Token[] removedTokens;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class TokenUpdateInfo
			{
				/// <summary>
				/// Type of tokenChange event. There are two TokenUpdate types: "added", "removed" Use Tokenizer.TokenUpdateType.Added for "added" and Tokenizer.TokenUpdateType.Removed for "removed".
				/// </summary>
				public string type;

				/// <summary>
				/// The array of tokens that are added. This parameter is used when tokenUpdate type is "added".
				/// </summary>
				public sap.m.Token[] addedTokens;

				/// <summary>
				/// The array of tokens that are removed. This parameter is used when tokenUpdate type is "removed".
				/// </summary>
				public sap.m.Token[] removedTokens;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ContainerNavigateInfo
			{
				/// <summary>
				/// The page which had been shown before navigation.
				/// </summary>
				public sap.ui.core.Control from;

				/// <summary>
				/// The ID of the page which had been shown before navigation.
				/// </summary>
				public string fromId;

				/// <summary>
				/// The page which is now shown after navigation.
				/// </summary>
				public sap.ui.core.Control to;

				/// <summary>
				/// The ID of the page which is now shown after navigation.
				/// </summary>
				public string toId;

				/// <summary>
				/// Whether the "to" page (more precisely: a control with the ID of the page which has been navigated to) had not been shown/navigated to before.
				/// </summary>
				public bool firstTime;

				/// <summary>
				/// Whether was a forward navigation, triggered by "to()".
				/// </summary>
				public bool isTo;

				/// <summary>
				/// Whether this was a back navigation, triggered by "back()".
				/// </summary>
				public bool isBack;

				/// <summary>
				/// Whether this was a navigation to the root page, triggered by "backToTop()".
				/// </summary>
				public bool isBackToTop;

				/// <summary>
				/// Whether this was a navigation to a specific page, triggered by "backToPage()".
				/// </summary>
				public bool isBackToPage;

				/// <summary>
				/// How the navigation was triggered, possible values are "to", "back", "backToPage", and "backToTop".
				/// </summary>
				public string direction;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ObjectPressInfo
			{
				/// <summary>
				/// Dom reference of the object header' icon to be used for positioning.
				/// </summary>
				public object domRef;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class CalendarSelectInfo
			{
				/// <summary>
				/// The selected appointment.
				/// </summary>
				public sap.ui.unified.CalendarAppointment appointment;

				/// <summary>
				/// The selected appointments in case a group appointment is selected.
				/// </summary>
				public sap.ui.unified.CalendarAppointment[] appointments;

				/// <summary>
				/// If set, the appointment was selected using multiple selection (e.g. Shift + single mouse click), meaning more than the current appointment could be selected.
				/// </summary>
				public bool multiSelect;

				/// <summary>
				/// Gives the ID of the DOM element of the clicked appointment
				/// </summary>
				public string domRefId;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class CloseInfo
			{
				/// <summary>
				/// This parameter refers to the control, which opens the QuickView.
				/// </summary>
				public sap.ui.core.Control openBy;

				/// <summary>
				/// This parameter contains the control, which triggers the close of the QuickView. It is undefined when running on desktop or tablet.
				/// </summary>
				public sap.m.Button origin;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class SliderChangeInfo
			{
				/// <summary>
				/// The current value of the rating after a live change event.
				/// </summary>
				public float value;

			}

			#endregion

			#region Delegates

			public delegate void SelectDelegate(sap.ui.@base.Event<sap.m.SelectInfo> oEvent, object oData);

			public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.m.SelectionChangeInfo> oEvent, object oData);

			public delegate void PickerChangeDelegate(sap.ui.@base.Event<sap.m.PickerChangeInfo> oEvent, object oData);

			public delegate void SubmitOrChangeDelegate(sap.ui.@base.Event<sap.m.SubmitOrChangeInfo> oEvent, object oData);

			public delegate void TilePressDelegate(sap.ui.@base.Event<sap.m.TilePressInfo> oEvent, object oData);

			public delegate void AfterOpenCloseBeforeDelegate(sap.ui.@base.Event<sap.m.AfterOpenCloseBeforeInfo> oEvent, object oData);

			public delegate void MessageListSelectDelegate(sap.ui.@base.Event<sap.m.MessageListSelectInfo> oEvent, object oData);

			public delegate void TokenChangeDelegate(sap.ui.@base.Event<sap.m.TokenChangeInfo> oEvent, object oData);

			public delegate void TokenUpdateDelegate(sap.ui.@base.Event<sap.m.TokenUpdateInfo> oEvent, object oData);

			public delegate void ContainerNavigateDelegate(sap.ui.@base.Event<sap.m.ContainerNavigateInfo> oEvent, object oData);

			public delegate void ObjectPressDelegate(sap.ui.@base.Event<sap.m.ObjectPressInfo> oEvent, object oData);

			public delegate void CalendarSelectDelegate(sap.ui.@base.Event<sap.m.CalendarSelectInfo> oEvent, object oData);

			public delegate void CloseDelegate(sap.ui.@base.Event<sap.m.CloseInfo> oEvent, object oData);

			public delegate void SliderChangeDelegate(sap.ui.@base.Event<sap.m.SliderChangeInfo> oEvent, object oData);

			#endregion

			#region Fields

			/// <summary>
			/// Hide the soft keyboard.
			/// </summary>
			public static object closeKeyboard;

			/// <summary>
			/// Search given control's parents and try to find iScroll.
			/// </summary>
			public static object getIScroll;

			/// <summary>
			/// Search given control's parents and try to find a ScrollDelegate.
			/// </summary>
			public static object getScrollDelegate;

			/// <summary>
			/// <pre>
			/// <code>sap.m.Support</code> shows the technical information for SAPUI5 Mobile Applications.
			/// This technical information includes
			///    * SAPUI5 Version
			///    * User Agent
			///    * Configurations (Bootstrap and Computed)
			///    * URI parameters
			///    * All loaded module names
			/// 
			/// In order to show the device information, the user must follow the following gestures.
			///    1 - Hold two finger for 3 seconds minimum.
			///    2 - Tab with a third finger while holding the first two fingers.
			/// 
			/// NOTE: This class is internal and all its functions must not be used by an application
			/// 
			/// As <code>sap.m.Support</code> is a static class, a <code>jQuery.sap.require("sap.m.Support");</code>
			/// statement must be implicitly executed before the class is used.
			/// 
			/// 
			/// Enable Support:
			/// --------------------------------------------------
			/// //import library
			/// jQuery.sap.require("sap.m.Support");
			/// 
			/// //By default after require, support is enabled but implicitly we can call
			/// sap.m.Support.on();
			/// 
			/// Disable Support:
			/// --------------------------------------------------
			/// sap.m.Support.off();
			/// </pre>
			/// </summary>
			public static object Support;

			#endregion

			#region Methods

			/// <summary>
			/// Returns invalid date value of UI5.
			/// </summary>
			[Obsolete("Deprecated since 1.12. UI5 returns null for invalid date")]
			/// <returns></returns>
			public extern static object getInvalidDate();

			/// <summary>
			/// Finds default locale settings once and returns always the same. We should not need to create new instance to get same locale settings This method keep the locale instance in the scope and returns the same after first run
			/// </summary>
			/// <returns>sap.ui.core.Locale instane</returns>
			public extern static object getLocale();

			/// <summary>
			/// Finds default locale data once and returns always the same.
			/// </summary>
			/// <returns>sap.ui.core.LocaleData instance</returns>
			public extern static object getLocaleData();

			/// <summary>
			/// Checks if the given parameter is a valid JsDate Object.
			/// </summary>
			/// <param name="value">Any variable to test.</param>
			/// <returns></returns>
			public extern static bool isDate(object value);

			#endregion

			/// <summary>
			/// Interface for controls which are suitable as a Header, Subheader or Footer of a Page. If the control does not want to get a context base style class, it has to implement the isContextSensitive method and return false
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface IBar
			{
			}
			/// <summary>
			/// Enumeration of possible size settings.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum Size
			{
					/// <summary>
					/// The size depends on the device it is running on. It is medium size for desktop and tablet and small size for phone.
					/// </summary>
					Auto,
					/// <summary>
					/// Large size.
					/// </summary>
					L,
					/// <summary>
					/// Medium size.
					/// </summary>
					M,
					/// <summary>
					/// The width and height of the control are determined by the width and height of the container the control is placed in. Please note: it is decided by the control whether or not sap.m.Size.Responsive is supported.
					/// </summary>
					Responsive,
					/// <summary>
					/// Small size.
					/// </summary>
					S,
					/// <summary>
					/// Extra small size.
					/// </summary>
					XS,
			}
			/// <summary>
			/// Interface for controls which are suitable as a Scale for the Slider/RangeSlider. Implementation of this interface should implement the following methods: <ul> <li><code>getTickmarksBetweenLabels</code></li> <li><code>calcNumberOfTickmarks</code></li> <li><code>handleResize</code></li> <li><code>getLabel</code></li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface IScale
			{
			}
			/// <summary>
			/// Defines which area of the control remains fixed at the top of the page during vertical scrolling as long as the control is in the viewport.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum Sticky
			{
					/// <summary>
					/// The column headers remain in a fixed position.
					/// </summary>
					ColumnHeaders,
					/// <summary>
					/// The header toolbar remains in a fixed position.
					/// </summary>
					HeaderToolbar,
					/// <summary>
					/// The info toolbar remains in a fixed position.
					/// </summary>
					InfoToolbar,
			}
			/// <summary>
			/// Represents an interface for controls, which are suitable as items for the sap.m.IconTabBar. The classes which implement this interface are: - sap.m.IconTabFilter - sap.m.IconTabSeparator
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface IconTab
			{
			}
			/// <summary>
			/// Available options for the wrapping behavior of a flex container.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexWrap
			{
					/// <summary>
					/// The flex container is single-line.
					/// </summary>
					NoWrap,
					/// <summary>
					/// The flex container is multi-line.
					/// </summary>
					Wrap,
					/// <summary>
					/// The flex container is multi-line with the cross-axis start and end being swapped.
					/// </summary>
					WrapReverse,
			}
			/// <summary>
			/// Defines the mode of the list.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ListMode
			{
					/// <summary>
					/// Delete mode (only one list item can be deleted via provided delete button)
					/// </summary>
					Delete,
					/// <summary>
					/// Multi selection mode (more than one list item can be selected).
					/// </summary>
					MultiSelect,
					/// <summary>
					/// Default mode (no selection).
					/// </summary>
					None,
					/// <summary>
					/// Right-positioned single selection mode (only one list item can be selected).
					/// </summary>
					SingleSelect,
					/// <summary>
					/// Left-positioned single selection mode (only one list item can be selected).
					/// </summary>
					SingleSelectLeft,
					/// <summary>
					/// Selected item is highlighted but no selection control is visible (only one list item can be selected).
					/// </summary>
					SingleSelectMaster,
			}
			/// <summary>
			/// Defines the visual indication and behaviour of the list items.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ListType
			{
					/// <summary>
					/// Indicates that the item is clickable via active feedback when item is pressed.
					/// </summary>
					Active,
					/// <summary>
					/// Enables detail button of the list item that fires <code>detailPress</code> event. Also see {@link sap.m.ListItemBase#attachDetailPress}.
					/// </summary>
					Detail,
					/// <summary>
					/// Enables {@link sap.m.ListType.Detail} and {@link sap.m.ListType.Active} enumerations together.
					/// </summary>
					DetailAndActive,
					/// <summary>
					/// Indicates the list item does not have any active feedback when item is pressed. <b>Note:</b> <code>Inactive</code> type cannot be used to disable list items.
					/// </summary>
					Inactive,
					/// <summary>
					/// Indicates the list item is navigable to show extra information about the item.
					/// </summary>
					Navigation,
			}
			/// <summary>
			/// Types of the Bar design.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum BarDesign
			{
					/// <summary>
					/// The Bar can be inserted into other controls and if the design is "Auto" then it inherits the design from parent control.
					/// </summary>
					Auto,
					/// <summary>
					/// The bar will be styled like a footer of the page.
					/// </summary>
					Footer,
					/// <summary>
					/// The bar will be styled like a header of the page.
					/// </summary>
					Header,
					/// <summary>
					/// The bar will be styled like a subheader of the page.
					/// </summary>
					SubHeader,
			}
			/// <summary>
			/// Enum for possible frame size types for sap.m.TileContent and sap.m.GenericTile control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FrameType
			{
					/// <summary>
					/// The Auto frame type that adjusts the size of the control to the content. Support for this type in sap.m.GenericTile is deprecated since 1.48.0.
					/// </summary>
					Auto,
					/// <summary>
					/// The 1x1 frame type.
					/// </summary>
					OneByOne,
					/// <summary>
					/// The 2x1 frame type.
					/// </summary>
					TwoByOne,
					/// <summary>
					/// The 2/3 frame type.
					/// </summary>
					TwoThirds,
			}
			/// <summary>
			/// Determines how the source image is used on the output DOM element.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ImageMode
			{
					/// <summary>
					/// The image is rendered with 'span' tag and the 'src' property is set to the 'background-image' CSS style on the output DOM element
					/// </summary>
					Background,
					/// <summary>
					/// The image is rendered with 'img' tag and the 'src' property is set to the src attribute on the output DOM element.
					/// </summary>
					Image,
			}
			/// <summary>
			/// A subset of input types that fits to a simple API returning one string. Not available on purpose: button, checkbox, hidden, image, password, radio, range, reset, search, submit.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum InputType
			{
					/// <summary>
					/// An input control for specifying a date value. The user can select a month, day of the month, and year.
					/// </summary>
					Date,
					/// <summary>
					/// An input control for specifying a date and time value. The user can select a month, day of the month, year, and time of day.
					/// </summary>
					Datetime,
					/// <summary>
					/// An input control for specifying a date and time value where the format depends on the locale.
					/// </summary>
					DatetimeLocale,
					/// <summary>
					/// A text field for specifying an email address. Brings up a keyboard optimized for email address entry.
					/// </summary>
					Email,
					/// <summary>
					/// An input control for selecting a month.
					/// </summary>
					Month,
					/// <summary>
					/// A text field for specifying a number. Brings up a number pad keyboard. Specifying an input type of \d* or [0-9]* is equivalent to using this type.
					/// </summary>
					Number,
					/// <summary>
					/// Password input where the user entry cannot be seen.
					/// </summary>
					Password,
					/// <summary>
					/// A text field for specifying a phone number. Brings up a phone pad keyboard.
					/// </summary>
					Tel,
					/// <summary>
					/// default (text)
					/// </summary>
					Text,
					/// <summary>
					/// An input control for specifying a time value. The user can select the hour, minute, and optionally AM or PM.
					/// </summary>
					Time,
					/// <summary>
					/// A text field for specifying a URL. Brings up a keyboard optimized for URL entry.
					/// </summary>
					Url,
					/// <summary>
					/// An input control for selecting a week.
					/// </summary>
					Week,
			}
			/// <summary>
			/// Enumeration of possible load statuses.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum LoadState
			{
					/// <summary>
					/// The control is disabled.
					/// </summary>
					Disabled,
					/// <summary>
					/// The control failed to load.
					/// </summary>
					Failed,
					/// <summary>
					/// The control has loaded.
					/// </summary>
					Loaded,
					/// <summary>
					/// The control is loading.
					/// </summary>
					Loading,
			}
			/// <summary>
			/// Different types for a button (predefined types).
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ButtonType
			{
					/// <summary>
					/// accept type (green button)
					/// </summary>
					Accept,
					/// <summary>
					/// back type (back navigation button for header)
					/// </summary>
					Back,
					/// <summary>
					/// default type (no special styling)
					/// </summary>
					Default,
					/// <summary>
					/// emphasized type
					/// </summary>
					Emphasized,
					/// <summary>
					/// ghost type
					/// </summary>
					Ghost,
					/// <summary>
					/// reject style (red button)
					/// </summary>
					Reject,
					/// <summary>
					/// transparent type
					/// </summary>
					Transparent,
					/// <summary>
					/// Unstyled type (no styling)
					/// </summary>
					Unstyled,
					/// <summary>
					/// up type (up navigation button for header)
					/// </summary>
					Up,
			}
			/// <summary>
			/// Enum for the type of {@link sap.m.Dialog} control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum DialogType
			{
					/// <summary>
					/// Dialog with type Message looks the same as the Stardard Dialog in Android. And it puts the left, right buttons to the bottom of the Dialog in iOS.
					/// </summary>
					Message,
					/// <summary>
					/// This is the default value for Dialog type. Stardard dialog in iOS has a header on the top and the left, right buttons are put inside the header. In android, the left, right buttons are put to the bottom of the Dialog.
					/// </summary>
					Standard,
			}
			/// <summary>
			/// Breakpoint names for different screen sizes.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ScreenSize
			{
					/// <summary>
					/// 1024px wide
					/// </summary>
					Desktop,
					/// <summary>
					/// 768px wide
					/// </summary>
					Large,
					/// <summary>
					/// 560px wide
					/// </summary>
					Medium,
					/// <summary>
					/// 240px wide
					/// </summary>
					Phone,
					/// <summary>
					/// 480px wide
					/// </summary>
					Small,
					/// <summary>
					/// 600px wide
					/// </summary>
					Tablet,
					/// <summary>
					/// 960px wide
					/// </summary>
					XLarge,
					/// <summary>
					/// 320px wide
					/// </summary>
					XSmall,
					/// <summary>
					/// 1120px wide
					/// </summary>
					XXLarge,
					/// <summary>
					/// 240px wide
					/// </summary>
					XXSmall,
			}
			/// <summary>
			/// Enumeration for different Select types.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SelectType
			{
					/// <summary>
					/// Will show the text.
					/// </summary>
					Default,
					/// <summary>
					/// Will show only the specified icon.
					/// </summary>
					IconOnly,
			}
			/// <summary>
			/// Enumaration for different switch types.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SwitchType
			{
					/// <summary>
					/// Switch with accept and reject icons
					/// </summary>
					AcceptReject,
					/// <summary>
					/// Will show "ON" and "OFF" translated to the current language or the custom text if provided
					/// </summary>
					Default,
			}
			/// <summary>
			/// Enumeration of possible value color settings.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ValueColor
			{
					/// <summary>
					/// Critical value color.
					/// </summary>
					Critical,
					/// <summary>
					/// Error value color.
					/// </summary>
					Error,
					/// <summary>
					/// Good value color.
					/// </summary>
					Good,
					/// <summary>
					/// Neutral value color.
					/// </summary>
					Neutral,
			}
			/// <summary>
			/// Different levels for headers.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum HeaderLevel
			{
					/// <summary>
					/// Header level 1
					/// </summary>
					H1,
					/// <summary>
					/// Header level 2
					/// </summary>
					H2,
					/// <summary>
					/// Header level 3
					/// </summary>
					H3,
					/// <summary>
					/// Header level 4
					/// </summary>
					H4,
					/// <summary>
					/// Header level 5
					/// </summary>
					H5,
					/// <summary>
					/// Header level 6
					/// </summary>
					H6,
			}
			/// <summary>
			/// Allowed tags for the implementation of the IBar interface.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum IBarHTMLTag
			{
					/// <summary>
					/// Renders as a div element.
					/// </summary>
					Div,
					/// <summary>
					/// Renders as a footer element.
					/// </summary>
					Footer,
					/// <summary>
					/// Renders as a header element.
					/// </summary>
					Header,
			}
			/// <summary>
			/// Available label display modes.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum LabelDesign
			{
					/// <summary>
					/// Displays the label in bold.
					/// </summary>
					Bold,
					/// <summary>
					/// Displays the label in normal mode.
					/// </summary>
					Standard,
			}
			/// <summary>
			/// Defines the layout options of the table popins.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PopinLayout
			{
					/// <summary>
					/// Sets block layout for rendering the table popins. The elements inside the popin container are rendered one below the other. <b>Note:</b> This option enables the former rendering behavior of the table popins.
					/// </summary>
					Block,
					/// <summary>
					/// Sets grid layout for rendering the table popins. The grid width for each table popin is comparatively larger than <code>GridSmall</code>, hence this allows less content to be rendered in a single popin row.
					/// 
					/// <b>Note:</b> This feature is currently not supported with Internet Explorer and Edge (version lower than 16) browsers.
					/// </summary>
					GridLarge,
					/// <summary>
					/// Sets grid layout for rendering the table popins. The grid width for each table popin is small, hence this allows more content to be rendered in a single popin row. This value defines small grid width for the table popins.
					/// 
					/// <b>Note:</b> This feature is currently not supported with Internet Explorer and Edge (version lower than 16) browsers.
					/// </summary>
					GridSmall,
			}
			/// <summary>
			/// Interface for controls which have the meaning of a breadcrumbs navigation.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface IBreadcrumbs
			{
			}
			/// <summary>
			/// Defines the display of table pop-ins.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PopinDisplay
			{
					/// <summary>
					/// Inside the table popin, header is displayed at the first line and cell content is displayed at the next line.
					/// </summary>
					Block,
					/// <summary>
					/// Inside the table popin, cell content is displayed next to the header in the same line. Note: If there is not enough space for the cell content then it jumps to the next line.
					/// </summary>
					Inline,
					/// <summary>
					/// Inside the table popin, only the cell content will be visible.
					/// </summary>
					WithoutHeader,
			}
			/// <summary>
			/// The mode of SplitContainer or SplitApp control to show/hide the master area.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SplitAppMode
			{
					/// <summary>
					/// Master area is hidden initially both in portrait and landscape. Master area can be opened by clicking on the top left corner button or swiping right. Swipe is only enabled on mobile devices. Master will keep the open state when changing the orientation of the device.
					/// </summary>
					HideMode,
					/// <summary>
					/// Master will be shown inside a Popover when in portrait mode
					/// </summary>
					PopoverMode,
					/// <summary>
					/// Master will automatically be hidden in portrait mode.
					/// </summary>
					ShowHideMode,
					/// <summary>
					/// Master will always be shown but in a compressed version when in portrait mode.
					/// </summary>
					StretchCompressMode,
			}
			/// <summary>
			/// Types of visual styles for the {@link sap.m.Toolbar}.
			/// 
			/// <b>Note:</b> Keep in mind that the styles are theme-dependent and can differ based on the currently used theme.
			/// 
			/// To preview the different combinations of <code>sap.m.ToolbarDesign</code> and <code>sap.m.ToolbarStyle</code>, see the <b>OverflowToolbar - Design and styling</b> sample of the {@link sap.m.OverflowToolbar} control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ToolbarStyle
			{
					/// <summary>
					/// Simplified visual style dependent on the used theme.
					/// 
					/// <b>Note:</b> For the Belize themes, the <code>sap.m.Toolbar</code> is displayed with no border.
					/// </summary>
					Clear,
					/// <summary>
					/// Default visual style dependent on the used theme.
					/// </summary>
					Standard,
			}
			/// <summary>
			/// Available options for the layout of individual elements along the cross axis of the flexbox layout overriding the default alignment.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexAlignSelf
			{
					/// <summary>
					/// Takes up the value of alignItems from the parent FlexBox
					/// </summary>
					Auto,
					/// <summary>
					/// If the flex item's inline axis is the same as the cross axis, this value is identical to "Start". Otherwise, it participates in baseline alignment: all participating box items on the line are aligned such that their baselines align, and the item with the largest distance between its baseline and its cross-start margin edge is placed flush against the cross-start edge of the line.
					/// </summary>
					Baseline,
					/// <summary>
					/// The flex item's margin box is centered in the cross axis within the line.
					/// </summary>
					Center,
					/// <summary>
					/// The cross-start margin edges of the flex item is placed flush with the cross-end edge of the line.
					/// </summary>
					End,
					/// <summary>
					/// Inherits the value from its parent.
					/// </summary>
					Inherit,
					/// <summary>
					/// The cross-start margin edges of the flex item is placed flush with the cross-start edge of the line.
					/// </summary>
					Start,
					/// <summary>
					/// Make the cross size of the item's margin box as close to the same size as the line as possible.
					/// </summary>
					Stretch,
			}
			/// <summary>
			/// Available directions for flex layouts.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexDirection
			{
					/// <summary>
					/// Flex items are laid out along the direction of the block axis (usually top to bottom).
					/// </summary>
					Column,
					/// <summary>
					/// Flex items are laid out along the reverse direction of the block axis (usually bottom to top).
					/// </summary>
					ColumnReverse,
					/// <summary>
					/// Inherits the value from its parent.
					/// </summary>
					Inherit,
					/// <summary>
					/// Flex items are laid out along the direction of the inline axis (text direction).
					/// </summary>
					Row,
					/// <summary>
					/// Flex items are laid out along the reverse direction of the inline axis (against the text direction).
					/// </summary>
					RowReverse,
			}
			/// <summary>
			/// Type of panels used in the personalization dialog.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum P13nPanelType
			{
					/// <summary>
					/// Panel type for column settings.
					/// </summary>
					columns,
					/// <summary>
					/// Panel type for dimension and measure settings.
					/// </summary>
					dimeasure,
					/// <summary>
					/// Panel type for filtering.
					/// </summary>
					filter,
					/// <summary>
					/// Panel type for grouping.
					/// </summary>
					group,
					/// <summary>
					/// Panel type for sorting.
					/// </summary>
					sort,
			}
			/// <summary>
			/// Types for the placement of Popover control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PlacementType
			{
					/// <summary>
					/// Popover will be placed automatically at the reference control.
					/// </summary>
					Auto,
					/// <summary>
					/// Popover will be placed at the bottom of the reference control.
					/// </summary>
					Bottom,
					/// <summary>
					/// Popover will be placed at the right or left side of the reference control.
					/// </summary>
					Horizontal,
					/// <summary>
					/// Deprecated - use <code>sap.m.PlacementType.HorizontalPreferredLeft</code> type.
					/// </summary>
					HorizontalPreferedLeft,
					/// <summary>
					/// Deprecated - use <code>sap.m.PlacementType.HorizontalPreferredRight</code> type.
					/// </summary>
					HorizontalPreferedRight,
					/// <summary>
					/// Popover will be placed at the right or left side of the reference control but will try to position on the left side if the space is greater than the Popover's width.
					/// </summary>
					HorizontalPreferredLeft,
					/// <summary>
					/// Popover will be placed at the right or left side of the reference control but will try to position on the right side if the space is greater than the Popover's width.
					/// </summary>
					HorizontalPreferredRight,
					/// <summary>
					/// Popover will be placed at the left side of the reference control.
					/// </summary>
					Left,
					/// <summary>
					/// Popover will be placed to the bottom of the reference control. If the available space is less than the Popover's height, it will appear to the top of the same reference control bottom border.
					/// </summary>
					PreferredBottomOrFlip,
					/// <summary>
					/// Popover will be placed to the left of the reference control. If the available space is less than the Popover's width, it will appear to the right of the same reference control left border.
					/// </summary>
					PreferredLeftOrFlip,
					/// <summary>
					/// Popover will be placed to the right of the reference control. If the available space is less than the Popover's width, it will appear to the left of the same reference control right border.
					/// </summary>
					PreferredRightOrFlip,
					/// <summary>
					/// Popover will be placed to the top of the reference control. If the available space is less than the Popover's height, it will appear to the bottom of the same reference control top border.
					/// </summary>
					PreferredTopOrFlip,
					/// <summary>
					/// Popover will be placed at the right side of the reference control.
					/// </summary>
					Right,
					/// <summary>
					/// Popover will be placed at the top of the reference control.
					/// </summary>
					Top,
					/// <summary>
					/// Popover will be placed at the top or bottom of the reference control.
					/// </summary>
					Vertical,
					/// <summary>
					/// Deprecated - use <code>sap.m.PlacementType.VerticalPreferredBottom</code> type.
					/// </summary>
					VerticalPreferedBottom,
					/// <summary>
					/// Deprecated - use <code>sap.m.PlacementType.VerticalPreferredTop</code> type.
					/// </summary>
					VerticalPreferedTop,
					/// <summary>
					/// Popover will be placed at the top or bottom of the reference control but will try to position on the bottom side if the space is greater than the Popover's height.
					/// </summary>
					VerticalPreferredBottom,
					/// <summary>
					/// Popover will be placed at the top or bottom of the reference control but will try to position on the top side if the space is greater than the Popover's height.
					/// </summary>
					VerticalPreferredTop,
			}
			/// <summary>
			/// Types of the Toolbar Design.
			/// 
			/// To preview the different combinations of <code>sap.m.ToolbarDesign</code> and <code>sap.m.ToolbarStyle</code>, see the <b>OverflowToolbar - Design and styling</b> sample of the {@link sap.m.OverflowToolbar} control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ToolbarDesign
			{
					/// <summary>
					/// The toolbar can be inserted into other controls and if the design is "Auto" then it inherits the design from parent control.
					/// </summary>
					Auto,
					/// <summary>
					/// The toolbar appears smaller than the regular size to show information(e.g: text, icon).
					/// </summary>
					Info,
					/// <summary>
					/// The toolbar has a solid background. Its content will be rendered in a standard way.
					/// </summary>
					Solid,
					/// <summary>
					/// The toolbar and its content will be displayed transparent.
					/// </summary>
					Transparent,
			}
			/// <summary>
			/// Available options for the layout of all elements along the cross axis of the flexbox layout.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexAlignItems
			{
					/// <summary>
					/// If the flex item's inline axes are the same as the cross axis, this value is identical to "Start". Otherwise, it participates in baseline alignment: all participating box items on the line are aligned such that their baselines align, and the item with the largest distance between its baseline and its cross-start margin edge is placed flush against the cross-start edge of the line.
					/// </summary>
					Baseline,
					/// <summary>
					/// The flex item's margin boxes are centered in the cross axis within the line.
					/// </summary>
					Center,
					/// <summary>
					/// The cross-start margin edges of the flex items are placed flush with the cross-end edge of the line.
					/// </summary>
					End,
					/// <summary>
					/// Inherits the value from its parent.
					/// </summary>
					Inherit,
					/// <summary>
					/// The cross-start margin edges of the flex items are placed flush with the cross-start edge of the line.
					/// </summary>
					Start,
					/// <summary>
					/// Make the cross size of the item's margin boxes as close to the same size as the line as possible.
					/// </summary>
					Stretch,
			}
			/// <summary>
			/// Determines the type of HTML elements used for rendering controls.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexRendertype
			{
					/// <summary>
					/// The UI5 controls are not wrapped in an additional HTML element, the surrounding Flex Box is a DIV element.
					/// </summary>
					Bare,
					/// <summary>
					/// The UI5 controls are wrapped in DIV elements.
					/// </summary>
					Div,
					/// <summary>
					/// The UI5 controls are wrapped in LI elements, the surrounding Flex Box is an unordered list (UL).
					/// </summary>
					List,
			}
			/// <summary>
			/// Enumeration for possible link-to-anchor conversion strategy.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum LinkConversion
			{
					/// <summary>
					/// Valid links with protocols, such as http, https, ftp and those starting with the string "www".
					/// </summary>
					All,
					/// <summary>
					/// Default mode (no conversion).
					/// </summary>
					None,
					/// <summary>
					/// Valid links with protocols, such as http, https, ftp.
					/// </summary>
					ProtocolOnly,
			}
			/// <summary>
			/// Defines which separator style will be applied for the items.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ListSeparators
			{
					/// <summary>
					/// Separators between the items including the last and the first one.
					/// </summary>
					All,
					/// <summary>
					/// Separators between the items. <b>Note:</b> This enumeration depends on the theme.
					/// </summary>
					Inner,
					/// <summary>
					/// No item separators.
					/// </summary>
					None,
			}
			/// <summary>
			/// Different modes for a MenuButton (predefined types).
			/// </summary>
			[External]
			[Namespace(false)]
			public enum MenuButtonMode
			{
					/// <summary>
					/// Default regular type (Menu button appears as a regular button, pressing opens a menu)
					/// </summary>
					Regular,
					/// <summary>
					/// Split type (Menu button appears as a split button, pressing fires the default action a menu, pressing the arrow part opens a menu)
					/// </summary>
					Split,
			}
			/// <summary>
			/// Directions for swipe event.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SwipeDirection
			{
					/// <summary>
					/// Both directions (left to right or right to left)
					/// </summary>
					Both,
					/// <summary>
					/// Swipe from left to right
					/// </summary>
					LeftToRight,
					/// <summary>
					/// Swipe from right to left.
					/// </summary>
					RightToLeft,
			}
			/// <summary>
			/// Used by the FacetFilter control to adapt its design according to type.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FacetFilterType
			{
					/// <summary>
					/// Forces FacetFilter to display in light mode.
					/// </summary>
					Light,
					/// <summary>
					/// Forces FacetFilter to display facet lists as a row of buttons, one button per facet. The FacetFilter will automatically adapt to the Light type when it detects smart phone sized displays.
					/// </summary>
					Simple,
			}
			/// <summary>
			/// Defines the mode of GenericTile.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum GenericTileMode
			{
					/// <summary>
					/// Default mode (Two lines for the header and one line for the subtitle).
					/// </summary>
					ContentMode,
					/// <summary>
					/// Header mode (Four lines for the header and one line for the subtitle).
					/// </summary>
					HeaderMode,
					/// <summary>
					/// Line mode (Implemented for both, cozy and compact densities. Generic Tile is displayed as in-line element, header and subheader are displayed in one line. In case the texts need more than one line, the representation depends on the used density. <b>Cozy:</b> The text will be truncated and the full text is shown in a tooltip as soon as the tile is hovered (desktop only). <b>Compact:</b> Header and subheader are rendered continuously spanning multiple lines, no tooltip is provided).
					/// </summary>
					LineMode,
			}
			/// <summary>
			/// Available Background Design.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum BackgroundDesign
			{
					/// <summary>
					/// A solid background color dependent on the theme.
					/// </summary>
					Solid,
					/// <summary>
					/// A translucent background depending on the opacity value of the theme.
					/// </summary>
					Translucent,
					/// <summary>
					/// Transparent background.
					/// </summary>
					Transparent,
			}
			/// <summary>
			/// Available options for the layout of container lines along the cross axis of the flexbox layout. <b>Note:</b> This property has no effect in Internet Explorer 10.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexAlignContent
			{
					/// <summary>
					/// Line are packed toward the center of the line.
					/// </summary>
					Center,
					/// <summary>
					/// Lines are packed toward the end of the line.
					/// </summary>
					End,
					/// <summary>
					/// Inherits the value from its parent.
					/// </summary>
					Inherit,
					/// <summary>
					/// Lines are evenly distributed in the line, with half-size spaces on either end. <b>Note:</b> This value behaves like SpaceBetween in Internet Explorer 10.
					/// </summary>
					SpaceAround,
					/// <summary>
					/// Lines are evenly distributed in the line.
					/// </summary>
					SpaceBetween,
					/// <summary>
					/// Lines are packed toward the start of the line.
					/// </summary>
					Start,
					/// <summary>
					/// Lines stretch to take up the remaining space.
					/// </summary>
					Stretch,
			}
			/// <summary>
			/// Defines the scopes of GenericTile enabling the developer to implement different "flavors" of tiles.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum GenericTileScope
			{
					/// <summary>
					/// Action scope (Possible footer and Error State information is overlaid, "Remove" and "More" icons are added to the tile).
					/// </summary>
					Actions,
					/// <summary>
					/// Default scope (The default scope of the tile, no action icons are rendered).
					/// </summary>
					Display,
			}
			/// <summary>
			/// Defines the different header styles.
			/// </summary>
			[External]
			[Namespace(false)]
			[Obsolete("Deprecated since 1.16. Has no functionality since 1.16.")]
			public enum ListHeaderDesign
			{
					/// <summary>
					/// Plain header style
					/// </summary>
					Plain,
					/// <summary>
					/// Standard header style
					/// </summary>
					Standard,
			}
			/// <summary>
			/// Defines the keyboard handling behavior of the <code>sap.m.List</code> or <code>sap.m.Table</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ListKeyboardMode
			{
					/// <summary>
					/// This mode is suitable if the number of items is limited and if there are editable fields within the item. While the last/first interactive element within an item has the focus, pressing tab/shift+tab moves the focus to the next/previous element in the tab chain after/before the item </code>.
					/// </summary>
					Edit,
					/// <summary>
					/// This default mode is suitable if the number of items is unlimited or if there is no editable field within the item. While the last/first interactive element within an item has the focus, pressing tab/shift+tab moves the focus to the next/previous element in the tab chain after/before the <code>sap.m.List</code> or <code>sap.m.Table</code>.
					/// </summary>
					Navigation,
			}
			/// <summary>
			/// Predefined types for ObjectMarker.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ObjectMarkerType
			{
					/// <summary>
					/// Draft type
					/// </summary>
					Draft,
					/// <summary>
					/// Favorite type
					/// </summary>
					Favorite,
					/// <summary>
					/// Flagged type
					/// </summary>
					Flagged,
					/// <summary>
					/// Locked type
					/// </summary>
					Locked,
					/// <summary>
					/// LockedBy type Use when you need to display the name of the user who locked the object.
					/// </summary>
					LockedBy,
					/// <summary>
					/// Unsaved type
					/// </summary>
					Unsaved,
					/// <summary>
					/// UnsavedBy type Use when you need to display the name of the user whos changes were unsaved.
					/// </summary>
					UnsavedBy,
			}
			/// <summary>
			/// Types for StandardTile.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum StandardTileType
			{
					/// <summary>
					/// Tile representing that something needs to be created
					/// </summary>
					Create,
					/// <summary>
					/// Monitor tile
					/// </summary>
					Monitor,
					/// <summary>
					/// Default type
					/// </summary>
					None,
			}
			/// <summary>
			/// Describes the behavior of tiles when displayed on a small-screened phone (374px wide and lower).
			/// </summary>
			[External]
			[Namespace(false)]
			public enum TileSizeBehavior
			{
					/// <summary>
					/// Default behavior: Tiles adapt to the size of the screen, getting smaller on small screens.
					/// </summary>
					Responsive,
					/// <summary>
					/// Tiles are small all the time, regardless of the actual screen size.
					/// </summary>
					Small,
			}
			/// <summary>
			/// A subset of DateTimeInput types that fit to a simple API returning one string.
			/// </summary>
			[External]
			[Namespace(false)]
			[Obsolete("Deprecated since 1.32.8. Instead, use dedicated <code>sap.m.DatePicker</code> and/or <code>sap.m.TimePicker</code> controls.")]
			public enum DateTimeInputType
			{
					/// <summary>
					/// An input control for specifying a date value. The user can select a month, day of the month, and year.
					/// </summary>
					Date,
					/// <summary>
					/// An input control for specifying a date and time value. The user can select a month, day of the month, year, and time of day.
					/// </summary>
					DateTime,
					/// <summary>
					/// An input control for specifying a time value. The user can select the hour, minute, and optionally AM or PM.
					/// </summary>
					Time,
			}
			/// <summary>
			/// Specifies <code>IconTabBar</code> header mode.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum IconTabHeaderMode
			{
					/// <summary>
					/// Inline. In this mode when the <code>count</code> and the <code>text</code> are set, they are displayed in one line.
					/// </summary>
					Inline,
					/// <summary>
					/// Standard. In this mode when the <code>count</code> and the <code>text</code> are set, they are displayed in two separate lines.
					/// </summary>
					Standard,
			}
			/// <summary>
			/// sap.m.NavContainerChild is an artificial interface with the only purpose to bear the documentation of pseudo events triggered by sap.m.NavContainer on its child controls when navigation occurs and child controls are displayed/hidden.
			/// 
			/// Interested parties outside the child control can listen to one or more of these events by registering a Delegate: <pre>
			/// page1.addEventDelegate({
			///    onBeforeShow: function(evt) {
			///       // page1 is about to be shown; act accordingly - if required you can read event information from the evt object
			///    },
			///    onAfterHide: function(evt) {
			///       // ...
			///    }
			/// });
			/// </pre>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface NavContainerChild
			{
			}
			/// <summary>
			/// Enum of the available deviation markers for the NumericContent control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum DeviationIndicator
			{
					/// <summary>
					/// The actual value is less than the target value.
					/// </summary>
					Down,
					/// <summary>
					/// No value.
					/// </summary>
					None,
					/// <summary>
					/// The actual value is more than the target value.
					/// </summary>
					Up,
			}
			/// <summary>
			/// Available options for the layout of elements along the main axis of the flexbox layout.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FlexJustifyContent
			{
					/// <summary>
					/// Flex items are packed toward the center of the line.
					/// </summary>
					Center,
					/// <summary>
					/// Flex items are packed toward the end of the line.
					/// </summary>
					End,
					/// <summary>
					/// Inherits the value from its parent.
					/// </summary>
					Inherit,
					/// <summary>
					/// Flex items are evenly distributed in the line, with half-size spaces on either end. <b>Note:</b> This value behaves like SpaceBetween in Internet Explorer 10.
					/// </summary>
					SpaceAround,
					/// <summary>
					/// Flex items are evenly distributed in the line.
					/// </summary>
					SpaceBetween,
					/// <summary>
					/// Flex items are packed toward the start of the line.
					/// </summary>
					Start,
			}
			/// <summary>
			/// Different modes for the <code>sap.m.TimePicker</code> mask.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum TimePickerMaskMode
			{
					/// <summary>
					/// <code>MaskInput</code> is disabled for the <code>sap.m.TimePicker</code>.
					/// </summary>
					Off,
					/// <summary>
					/// <code>MaskInput</code> is enabled for the <code>sap.m.TimePicker</code>.
					/// </summary>
					On,
			}
			/// <summary>
			/// Enum for the state of {@link sap.m.DraftIndicator} control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum DraftIndicatorState
			{
					/// <summary>
					/// This is the default value for DraftIndicatorState type. This state has no visual information displayed.
					/// </summary>
					Clear,
					/// <summary>
					/// Indicates that the draft is already saved
					/// </summary>
					Saved,
					/// <summary>
					/// Indicates that the draft currently is being saved
					/// </summary>
					Saving,
			}
			/// <summary>
			/// Available Filter Item Design.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum IconTabFilterDesign
			{
					/// <summary>
					/// A horizontally layouted design providing more space for texts.
					/// </summary>
					Horizontal,
					/// <summary>
					/// A vertically layouted design using minimum horizontal space.
					/// </summary>
					Vertical,
			}
			/// <summary>
			/// Defines how the input display text should be formatted.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum InputTextFormatMode
			{
					/// <summary>
					/// Key
					/// </summary>
					Key,
					/// <summary>
					/// A key-value pair formatted like "(key) text"
					/// </summary>
					KeyValue,
					/// <summary>
					/// Text
					/// </summary>
					Value,
					/// <summary>
					/// A value-key pair formatted like "text (key)"
					/// </summary>
					ValueKey,
			}
			/// <summary>
			/// Available Panel Accessible Landmark Roles.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PanelAccessibleRole
			{
					/// <summary>
					/// Represents the ARIA role <code>complementary</code>. A section of the page, designed to be complementary to the main content at a similar level in the DOM hierarchy.
					/// </summary>
					Complementary,
					/// <summary>
					/// Represents the ARIA role <code>Form</code>. A landmark region that contains a collection of items and objects that, as a whole, create a form.
					/// </summary>
					Form,
					/// <summary>
					/// Represents the ARIA role <code>Region</code>. A section of a page, that is important enough to be included in a page summary or table of contents.
					/// </summary>
					Region,
			}
			/// <summary>
			/// Defines the growing direction of the <code>sap.m.List</code> or <code>sap.m.Table</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ListGrowingDirection
			{
					/// <summary>
					/// User has to scroll down to load more items or the growing button is displayed at the bottom.
					/// </summary>
					Downwards,
					/// <summary>
					/// User has to scroll up to load more items or the growing button is displayed at the top. <b>Note:</b> If this option is active, there should not be any other control than <code>sap.m.List</code> inside its <code>ScollContainer</code>.
					/// </summary>
					Upwards,
			}
			/// <summary>
			/// Available Page Background Design.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PageBackgroundDesign
			{
					/// <summary>
					/// Page background color when a List is set as the Page content.
					/// </summary>
					List,
					/// <summary>
					/// A solid background color dependent on the theme.
					/// </summary>
					Solid,
					/// <summary>
					/// Standard Page background color.
					/// </summary>
					Standard,
					/// <summary>
					/// Transparent background for the page.
					/// </summary>
					Transparent,
			}
			/// <summary>
			/// Types of string filter operators.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum StringFilterOperator
			{
					/// <summary>
					/// Checks if any word in the text starts with the search string.
					/// </summary>
					AnyWordStartsWith,
					/// <summary>
					/// Checks if the text contains the search string.
					/// </summary>
					Contains,
					/// <summary>
					/// Checks if the text is equal with the search string.
					/// </summary>
					Equals,
					/// <summary>
					/// Checks if the text starts with the search string.
					/// </summary>
					StartsWith,
			}
			/// <summary>
			/// Types of LightBox loading stages.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum LightBoxLoadingStates
			{
					/// <summary>
					/// The LightBox image could not load.
					/// </summary>
					Error,
					/// <summary>
					/// The LightBox image has loaded.
					/// </summary>
					Loaded,
					/// <summary>
					/// The LightBox image is still loading.
					/// </summary>
					Loading,
					/// <summary>
					/// The LightBox image has timed out, could not load.
					/// </summary>
					TimeOutError,
			}
			/// <summary>
			/// Marker interface for controls which are suitable as items for the ObjectHeader.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface ObjectHeaderContainer
			{
			}
			/// <summary>
			/// Available step modes for {@link sap.m.StepInput}.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum StepInputStepModeType
			{
					/// <summary>
					/// Choosing increase/decrease button will add/subtract the <code>step</code> value to/from the current value. For example, if <code>step</code> is 5, current <code>value</code> is 17 and increase button is chosen, the result will be 22 (5+17).
					/// 
					/// <b>Note:</b> Using keyboard PageUp/PageDown will add/subtract the <code>step</code> multiplied by the <code>largerStep</code> values to/from the current <code>value</code>. For example, if <code>step</code> is 5, <code>largerStep</code> is 3, current <code>value</code> is 17 and PageUp is chosen, the result would be 32 (5*3+17).
					/// 
					/// For more information, see {@link sap.m.StepInput}'s <code>step</code>, <code>largerStep</code> and <code>stepMode</code> properties.
					/// </summary>
					AdditionAndSubtraction,
					/// <summary>
					/// Pressing increase/decrease button will increase/decrease the current <code>value</code> to the closest number that is divisible by the <code>step</code>.
					/// 
					/// For example, if <code>step</code> is 5, current <code>value</code> is 17 and increase button is chosen, the result will be 20 as it is the closest larger number that is divisible by 5.
					/// 
					/// <b>Note:</b> Using keyboard PageUp/PageDown will increase/decrease the current <code>value</code> to the closest number that is divisible by the multiplication of the <code>step</code> and the <code>largerStep</code> values. For example, if <code>step</code> is 5, <code>largerStep</code> is 3, current <code>value</code> is 17 and PageUp is chosen, the result would be 30 as it is the closest larger number that is divisible by 15.
					/// 
					/// The logic above will work only if both <code>step</code> and <code>largerStep</code> are integers.
					/// 
					/// For more information, see {@link sap.m.StepInput}'s <code>step</code>, <code>largerStep</code> and <code>stepMode</code> properties.
					/// </summary>
					Multiple,
			}
			/// <summary>
			/// Types for the placement of message Popover control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum VerticalPlacementType
			{
					/// <summary>
					/// Popover will be placed at the bottom of the reference control.
					/// </summary>
					Bottom,
					/// <summary>
					/// Popover will be placed at the top of the reference control.
					/// </summary>
					Top,
					/// <summary>
					/// Popover will be placed at the top or bottom of the reference control.
					/// </summary>
					Vertical,
			}
			/// <summary>
			/// Predefined visibility for ObjectMarker.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum ObjectMarkerVisibility
			{
					/// <summary>
					/// Shows icon and text
					/// </summary>
					IconAndText,
					/// <summary>
					/// Shows only icon
					/// </summary>
					IconOnly,
					/// <summary>
					/// Shows only text
					/// </summary>
					TextOnly,
			}
			[External]
			[Namespace(false)]
			public enum P13nConditionOperation
			{
					Ascending,
					Average,
					BT,
					Contains,
					Descending,
					Empty,
					EndsWith,
					EQ,
					GE,
					GroupAscending,
					GroupDescending,
					GT,
					Initial,
					LE,
					LT,
					Maximum,
					Minimum,
					NotEmpty,
					StartsWith,
					Total,
			}
			/// <summary>
			/// Carousel arrows align.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum CarouselArrowsPlacement
			{
					/// <summary>
					/// Carousel arrows are placed on the sides of the current Carousel page.
					/// </summary>
					Content,
					/// <summary>
					/// Carousel arrows are placed on the sides of the page indicator of the Carousel.
					/// </summary>
					PageIndicator,
			}
			/// <summary>
			/// FacetFilterList data types.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum FacetFilterListDataType
			{
					/// <summary>
					/// >An input control for specifying a Boolean value
					/// </summary>
					Boolean,
					/// <summary>
					/// An input control for specifying a date value. The user can select a month, day of the month, and year.
					/// </summary>
					Date,
					/// <summary>
					/// An input control for specifying a date and time value. The user can select a month, day of the month, year, and time of day.
					/// </summary>
					DateTime,
					/// <summary>
					/// >An input control for specifying a Float value
					/// </summary>
					Float,
					/// <summary>
					/// >An input control for specifying an Integer value
					/// </summary>
					Integer,
					/// <summary>
					/// >An input control for specifying a String value
					/// </summary>
					String,
					/// <summary>
					/// An input control for specifying a time value. The user can select the hour, minute, and optionally AM or PM.
					/// </summary>
					Time,
			}
			/// <summary>
			/// Interface for controls which can have special behavior inside <code>sap.m.OverflowToolbar</code>. Controls that implement this interface must provide a <code>getOverflowToolbarConfig</code> method that accepts no arguments and returns an object with the following fields: <ul> <li><code>canOverflow</code> - A boolean that tells whether the control can move to the overflow menu or not.
			/// 
			/// <b>Note:</b> Even if <code>canOverflow</code> is set to <code>false</code>, the <code>propsUnrelatedToSize</code> field is taken into account, allowing to optimize the behavior of controls that do not need to overflow, but are used in an <code>sap.m.OverflowToolbar</code> regardless.</li>
			/// 
			/// <li><code>autoCloseEvents</code> - An array of strings, listing all of the control's events that should trigger the closing of the overflow menu, when fired.</li>
			/// 
			/// <li><code>propsUnrelatedToSize</code> - An array of strings, listing all of the control's properties that, when changed, should not cause the overflow toolbar to invalidate.
			/// 
			/// <b>Note:</b> By default <code>sap.m.OverflowToolbar</code> invalidates whenever any property of a child control changes. This is to ensure that whenever the size of a child control changes, the overflow toolbar's layout is recalculated. Some properties however do not affect control size, making it unnecessary to invalidate the overflow toolbar when they change. You can list them here for optimization purposes.</li>
			/// 
			/// <li><code>onBeforeEnterOverflow(oControl)</code> - A callback function that will be invoked before moving the control into the overflow menu. The control instance will be passed as an argument.
			/// 
			/// <b>Note:</b> The context of the function is not the control instance (use the <code>oControl</code> parameter for this purpose), but rather an internal helper object, associated with the current <code>sap.m.OverflowToolbar</code> instance. This object only needs to be manipulated in special cases (e.g. when you want to store state on it, rather than on the control instance).</li>
			/// 
			/// <li><code>onAfterExitOverflow(oControl)</code> - A callback function that will be invoked after taking the control out of the overflow menu (before moving it back to the toolbar itself). The control instance will be passed as an argument.
			/// 
			/// <b>Note:</b> See: <code>onBeforeEnterOverflow</code> for details about the function's context.</li>
			/// 
			/// <li><code>getCustomImportance()</code> - A function that, if provided, will be called to determine the priority of the control. This function must return a value of type <code>sap.m.OverflowToolbarPriority</code>. The string "Medium" is also accepted and interpreted as priority between <code>Low</code> and <code>High<code>.
			/// 
			/// <b>Note:</b> Normally priority in <code>sap.m.OverflowToolbar</code> is managed with the <code>priority</code> property of <code>sap.m.OverflowToolbarLayoutData</code>. However, some controls may have other means of defining priority, such as dedicated properties or other types of layout data for that purpose. In summary, implementing this function allows a control to override the default priority logic (<code>sap.m.OverflowToolbarLayoutData</code>) by providing its own.</li> </ul>
			/// 
			/// <b>Important:</b> In addition, the control can implement a CSS class, scoped with the <code>.sapMOverflowToolbarMenu-CTX</code> context selector, that will be applied whenever the control is inside the overflow menu. For example, to make your control take up the whole width of the overflow menu, you can add a context class to your control's base CSS file like this:
			/// 
			/// <pre>
			///       .sapMOverflowToolbarMenu-CTX .sapMyControlClass {
			///       	width: 100%;
			///       }
			///   </pre>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial interface IOverflowToolbarContent
			{
			}
			/// <summary>
			/// Defines the priorities of the controls within {@link sap.m.OverflowToolbar}.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum OverflowToolbarPriority
			{
					/// <summary>
					/// Deprecated - Use <code>sap.m.OverflowToolbarPriority.AlwaysOverflow</code> instead
					/// </summary>
					Always,
					/// <summary>
					/// AlwaysOverflow priority forces OverflowToolbar items to remain always in the overflow area
					/// </summary>
					AlwaysOverflow,
					/// <summary>
					/// Disappear priority OverflowToolbar items overflow before the items with higher priority such as Low and High priority items and remain hidden in the overflow area
					/// </summary>
					Disappear,
					/// <summary>
					/// High priority OverflowToolbar items overflow after the items with lower priority
					/// </summary>
					High,
					/// <summary>
					/// Low priority OverflowToolbar items overflow before the items with higher priority such as High priority items
					/// </summary>
					Low,
					/// <summary>
					/// Deprecated - Use <code>sap.m.OverflowToolbarPriority.NeverOverflow</code> instead
					/// </summary>
					Never,
					/// <summary>
					/// NeverOverflow priority forces OverflowToolbar items to remain always in the toolbar
					/// </summary>
					NeverOverflow,
			}
			/// <summary>
			/// Available validation modes for {@link sap.m.StepInput}.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum StepInputValidationMode
			{
					/// <summary>
					/// Validation happens on <code>FocusOut</code>.
					/// </summary>
					FocusOut,
					/// <summary>
					/// Validation happens on <code>LiveChange</code>.
					/// </summary>
					LiveChange,
			}
			/// <summary>
			/// QuickViewGroupElement is a combination of one label and another control (Link or Text) associated to this label.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum QuickViewGroupElementType
			{
					/// <summary>
					/// Displays an e-mail link
					/// </summary>
					email,
					/// <summary>
					/// Displayes a regular HTML link
					/// </summary>
					link,
					/// <summary>
					/// Displays a phone number link for direct dialing and an icon for sending a text message
					/// </summary>
					mobile,
					/// <summary>
					/// Dislpays a link for navigating to another QuickViewPage
					/// </summary>
					pageLink,
					/// <summary>
					/// Displays a phone number link for direct dialing
					/// </summary>
					phone,
					/// <summary>
					/// Dislpays text
					/// </summary>
					text,
			}
			/// <summary>
			/// Possible values for the visualization of float values in the RatingIndicator control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum RatingIndicatorVisualMode
			{
					/// <summary>
					/// Values are rounded to the nearest integer value (e.g. 1.7 -> 2).
					/// </summary>
					Full,
					/// <summary>
					/// Values are rounded to the nearest half value (e.g. 1.7 -> 1.5).
					/// </summary>
					Half,
			}
			/// <summary>
			/// A list of the default built-in views in a {@link sap.m.PlanningCalendar}, described by their keys.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum PlanningCalendarBuiltInView
			{
					/// <summary>
					/// Represents the key of the built-in view, in which the intervals have the size of one day.
					/// </summary>
					Day,
					/// <summary>
					/// Represents the key of the built-in view, in which the intervals have the size of one hour.
					/// </summary>
					Hour,
					/// <summary>
					/// Represents the key of the built-in view, in which the intervals have the size of one month.
					/// </summary>
					Month,
					/// <summary>
					/// Represents the key of the built-in view, in which the intervals have the size of one day where 31 days are displayed, starting with the first day of the month.
					/// </summary>
					OneMonth,
					/// <summary>
					/// Represents the key of the built-in view, in which the intervals have the size of one day where 7 days are displayed, starting with the first day of the week.
					/// </summary>
					Week,
			}
			/// <summary>
			/// Enumeration for different action levels in sap.m.SelectionDetails control.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SelectionDetailsActionLevel
			{
			}
			/// <summary>
			/// Defines the keyboard navigation mode.
			/// </summary>
			[External]
			[Namespace(false)]
			public enum SelectListKeyboardNavigationMode
			{
					/// <summary>
					/// Keyboard navigation is delimited at the last item or first item of the list.
					/// </summary>
					Delimited,
					/// <summary>
					/// Keyboard navigation is disabled.
					/// </summary>
					None,
			}
		}
	}
}
