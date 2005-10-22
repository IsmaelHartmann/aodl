/*
 * $Id: FamiliyStyles.cs,v 1.3 2005/10/22 15:52:10 larsbm Exp $
 */

using System;

namespace AODL.TextDocument.Style
{	
	/// <summary>
	/// Class that represents th possible values. For a style emlement and his family-style attribute.
	/// </summary>
	public class FamiliyStyles
	{
		/// <summary>
		/// table
		/// </summary>
		public static readonly string Table			= "table";
		/// <summary>
		/// column
		/// </summary>
		public static readonly string TableColumn	= "table-column";
		/// <summary>
		/// cell
		/// </summary>
		public static readonly string TableCell		= "table-cell";
		/// <summary>
		/// row
		/// </summary>
		public static readonly string TableRow		= "table-row";
		/// <summary>
		/// paragraph
		/// </summary>
		public static readonly string Paragraph		= "paragraph";
		/// <summary>
		/// text
		/// </summary>
		public static readonly string Text			= "text";
		/// <summary>
		/// graphic
		/// </summary>
		public static readonly string Graphic		= "graphic";
	}
}

/*
 * $Log: FamiliyStyles.cs,v $
 * Revision 1.3  2005/10/22 15:52:10  larsbm
 * - Changed some styles from Enum to Class with statics
 * - Add full support for available OpenOffice fonts
 *
 * Revision 1.2  2005/10/08 07:50:15  larsbm
 * - added cvs tags
 *
 */