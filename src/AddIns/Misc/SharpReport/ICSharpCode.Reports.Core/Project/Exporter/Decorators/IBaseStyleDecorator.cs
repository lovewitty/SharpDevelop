﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Peter Forstmeier" email="peter.forstmeier@t-online.de"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace ICSharpCode.Reports.Core.Exporter
{
	public interface IBaseStyleDecorator
	{
		bool DrawBorder { get; set; }
		Color BackColor { get; set; }
		iTextSharp.text.Color PdfBackColor { get; }
		Color ForeColor { get; set; }
		iTextSharp.text.Color PdfForeColor { get; }
		Point Location { get; set; }
		Size Size { get; set; }
		Rectangle DisplayRectangle { get; }
	}
}