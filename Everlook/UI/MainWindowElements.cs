﻿//
//  MainWindowElements.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2016 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using Gtk;
using OpenTK;
using UIElement = Gtk.Builder.ObjectAttribute;

namespace Everlook.UI
{
	public sealed partial class MainWindow
	{
		/*
			Main UI elements
		*/
		[UIElement] private readonly ToolButton AboutButton;
		[UIElement] private readonly AboutDialog AboutDialog;
		[UIElement] private readonly ToolButton PreferencesButton;

		[UIElement] private readonly Alignment ViewportAlignment;
		private readonly GLWidget ViewportWidget;
		private bool viewportHasPendingRedraw;

		/*
			Export queue elements
		*/
		[UIElement] private readonly TreeView ExportQueueTreeView;
		[UIElement] private readonly ListStore ExportQueueListStore;

		[UIElement] private readonly Menu QueueContextMenu;
		[UIElement] private readonly ImageMenuItem RemoveQueueItem;

		/*
			Game explorer elements
		*/
		[UIElement] private readonly TreeView GameExplorerTreeView;
		[UIElement] private readonly TreeStore GameExplorerTreeStore;
		[UIElement] private readonly TreeModelFilter GameExplorerTreeFilter;
		[UIElement] private readonly TreeModelSort GameExplorerTreeSorter;

		[UIElement] private readonly Menu FileContextMenu;
		[UIElement] private readonly ImageMenuItem ExtractItem;
		[UIElement] private readonly ImageMenuItem ExportItem;
		[UIElement] private readonly ImageMenuItem OpenItem;
		[UIElement] private readonly ImageMenuItem CopyItem;
		[UIElement] private readonly ImageMenuItem QueueItem;

		/*
			General item control elements
		*/

		[UIElement] private readonly Notebook ItemControlNotebook;

		/*
			Image control elements
		*/
		[UIElement] private readonly CheckButton RenderAlphaCheckButton;
		[UIElement] private readonly CheckButton RenderRedCheckButton;
		[UIElement] private readonly CheckButton RenderGreenCheckButton;
		[UIElement] private readonly CheckButton RenderBlueCheckButton;


		/*
			Status bar elements
		*/
		[UIElement] private readonly Statusbar MainStatusBar;
		[UIElement] private readonly Spinner StatusSpinner;

		/*
			Model control elements
		*/

		/*
			Animation control elements
		*/

		/*
			Audio control elements
		*/
	}
}