//
// ProfessionalColors.cs
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of color_table software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and color_table permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2006 Novell, Inc.
//
// Authors:
//	Jonathan Pobst (monkey@jpobst.com)
//

using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms
{
	public sealed class ProfessionalColors
	{
		private static ProfessionalColorTable color_table = new ProfessionalColorTable();

		#region Private Constructor
		private ProfessionalColors () {}
		#endregion
		
		#region Static Properties
		public static Color_ ButtonCheckedGradientBegin { get { return color_table.ButtonCheckedGradientBegin; } }
		public static Color_ ButtonCheckedGradientEnd { get { return color_table.ButtonCheckedGradientEnd; } }
		public static Color_ ButtonCheckedGradientMiddle { get { return color_table.ButtonCheckedGradientMiddle; } }
		public static Color_ ButtonCheckedHighlight { get { return color_table.ButtonCheckedHighlight; } }
		public static Color_ ButtonCheckedHighlightBorder { get { return color_table.ButtonCheckedHighlightBorder; } }
		public static Color_ ButtonPressedBorder { get { return color_table.ButtonPressedBorder; } }
		public static Color_ ButtonPressedGradientBegin { get { return color_table.ButtonPressedGradientBegin; } }
		public static Color_ ButtonPressedGradientEnd { get { return color_table.ButtonPressedGradientEnd; } }
		public static Color_ ButtonPressedGradientMiddle { get { return color_table.ButtonPressedGradientMiddle; } }
		public static Color_ ButtonPressedHighlight { get { return color_table.ButtonPressedHighlight; } }
		public static Color_ ButtonPressedHighlightBorder { get { return color_table.ButtonPressedHighlightBorder; } }
		public static Color_ ButtonSelectedBorder { get { return color_table.ButtonSelectedBorder; } }
		public static Color_ ButtonSelectedGradientBegin { get { return color_table.ButtonSelectedGradientBegin; } }
		public static Color_ ButtonSelectedGradientEnd { get { return color_table.ButtonSelectedGradientEnd; } }
		public static Color_ ButtonSelectedGradientMiddle { get { return color_table.ButtonSelectedGradientMiddle; } }
		public static Color_ ButtonSelectedHighlight { get { return color_table.ButtonSelectedHighlight; } }
		public static Color_ ButtonSelectedHighlightBorder { get { return color_table.ButtonSelectedHighlightBorder; } }
		public static Color_ CheckBackground { get { return color_table.CheckBackground; } }
		public static Color_ CheckPressedBackground { get { return color_table.CheckPressedBackground; } }
		public static Color_ CheckSelectedBackground { get { return color_table.CheckSelectedBackground; } }
		public static Color_ GripDark { get { return color_table.GripDark; } }
		public static Color_ GripLight { get { return color_table.GripLight; } }
		public static Color_ ImageMarginGradientBegin { get { return color_table.ImageMarginGradientBegin; } }
		public static Color_ ImageMarginGradientEnd { get { return color_table.ImageMarginGradientEnd; } }
		public static Color_ ImageMarginGradientMiddle { get { return color_table.ImageMarginGradientMiddle; } }
		public static Color_ ImageMarginRevealedGradientBegin { get { return color_table.ImageMarginRevealedGradientBegin; } }
		public static Color_ ImageMarginRevealedGradientEnd { get { return color_table.ImageMarginRevealedGradientEnd; } }
		public static Color_ ImageMarginRevealedGradientMiddle { get { return color_table.ImageMarginRevealedGradientMiddle; } }
		public static Color_ MenuBorder { get { return color_table.MenuBorder; } }
		public static Color_ MenuItemBorder { get { return color_table.MenuItemBorder; } }
		public static Color_ MenuItemPressedGradientBegin { get { return color_table.MenuItemPressedGradientBegin; } }
		public static Color_ MenuItemPressedGradientEnd { get { return color_table.MenuItemPressedGradientEnd; } }
		public static Color_ MenuItemPressedGradientMiddle { get { return color_table.MenuItemPressedGradientMiddle; } }
		public static Color_ MenuItemSelected { get { return color_table.MenuItemSelected; } }
		public static Color_ MenuItemSelectedGradientBegin { get { return color_table.MenuItemSelectedGradientBegin; } }
		public static Color_ MenuItemSelectedGradientEnd { get { return color_table.MenuItemSelectedGradientEnd; } }
		public static Color_ MenuStripGradientBegin { get { return color_table.MenuStripGradientBegin; } }
		public static Color_ MenuStripGradientEnd { get { return color_table.MenuStripGradientEnd; } }
		public static Color_ OverflowButtonGradientBegin { get { return color_table.OverflowButtonGradientBegin; } }
		public static Color_ OverflowButtonGradientEnd { get { return color_table.OverflowButtonGradientEnd; } }
		public static Color_ OverflowButtonGradientMiddle { get { return color_table.OverflowButtonGradientMiddle; } }
		public static Color_ RaftingContainerGradientBegin { get { return color_table.RaftingContainerGradientBegin; } }
		public static Color_ RaftingContainerGradientEnd { get { return color_table.RaftingContainerGradientEnd; } }
		public static Color_ SeparatorDark { get { return color_table.SeparatorDark; } }
		public static Color_ SeparatorLight { get { return color_table.SeparatorLight; } }
		public static Color_ StatusStripGradientBegin { get { return color_table.StatusStripGradientBegin; } }
		public static Color_ StatusStripGradientEnd { get { return color_table.StatusStripGradientEnd; } }
		public static Color_ ToolStripBorder { get { return color_table.ToolStripBorder; } }
		public static Color_ ToolStripContentPanelGradientBegin { get { return color_table.ToolStripContentPanelGradientBegin; } }
		public static Color_ ToolStripContentPanelGradientEnd { get { return color_table.ToolStripContentPanelGradientEnd; } }
		public static Color_ ToolStripDropDownBackground { get { return color_table.ToolStripDropDownBackground; } }
		public static Color_ ToolStripGradientBegin { get { return color_table.ToolStripGradientBegin; } }
		public static Color_ ToolStripGradientEnd { get { return color_table.ToolStripGradientEnd; } }
		public static Color_ ToolStripGradientMiddle { get { return color_table.ToolStripGradientMiddle; } }
		public static Color_ ToolStripPanelGradientBegin { get { return color_table.ToolStripPanelGradientBegin; } }
		public static Color_ ToolStripPanelGradientEnd { get { return color_table.ToolStripPanelGradientEnd; } }
		#endregion
	}
}
