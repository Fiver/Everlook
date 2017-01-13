﻿//
//  ReferenceEnumeratedEventArgs.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
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

using System;

namespace Everlook.Explorer
{
	/// <summary>
	/// Reference enumerated event arguments.
	/// </summary>
	public class ReferenceEnumeratedEventArgs : EventArgs
	{
		/// <summary>
		/// Contains the enumerated file reference.
		/// </summary>
		/// <value>The item.</value>
		public FileReference Reference { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ReferenceEnumeratedEventArgs"/> class.
		/// </summary>
		/// <param name="inReference">In item.</param>
		public ReferenceEnumeratedEventArgs(FileReference inReference)
		{
			this.Reference = inReference;
		}
	}
}