﻿#region MIT License
/*Copyright (c) 2012 Robert Rouhani <robert.rouhani@gmail.com>

SharpFont based on Tao.FreeType, Copyright (c) 2003-2007 Tao Framework Team

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

using System;

namespace SharpFont.Cache
{
	/// <summary>
	/// An opaque handle to a cache node object. Each cache node is
	/// reference-counted. A node with a count of 0 might be flushed out of a
	/// full cache whenever a lookup request is performed.
	/// 
	/// If you look up nodes, you have the ability to ‘acquire’ them, i.e., to
	/// increment their reference count. This will prevent the node from being
	/// flushed out of the cache until you explicitly ‘release’ it.
	/// </summary>
	/// <see cref="FTC.NodeUnref"/>
	/// <seealso cref="FTC.SbitCacheLookup"/>
	/// <seealso cref="FTC.ImageCacheLookup"/>
	public class Node
	{
		internal IntPtr reference;

		internal Node(IntPtr reference)
		{
			this.reference = reference;
		}
	}
}
