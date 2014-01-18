/**
 * Couchbase Lite for .NET
 *
 * Original iOS version by Jens Alfke
 * Android Port by Marty Schoch, Traun Leyden
 * C# Port by Zack Gramana
 *
 * Copyright (c) 2012, 2013, 2014 Couchbase, Inc. All rights reserved.
 * Portions (c) 2013, 2014 Xamarin, Inc. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

using System;
using Couchbase.Lite;
using Sharpen;

namespace Couchbase.Lite
{
	[System.Serializable]
	public class CouchbaseLiteException : Exception
	{
		private Status status;

		public CouchbaseLiteException(int statusCode)
		{
			this.status = new Status(statusCode);
		}

		public CouchbaseLiteException(Status status)
		{
			this.status = status;
		}

		public CouchbaseLiteException(string detailMessage, Status status) : base(detailMessage
			)
		{
			this.status = status;
		}

		public CouchbaseLiteException(string detailMessage, int statusCode) : this(detailMessage
			, new Status(statusCode))
		{
		}

		public CouchbaseLiteException(string detailMessage, Exception throwable, Status status
			) : base(detailMessage, throwable)
		{
			this.status = status;
		}

		public CouchbaseLiteException(Exception throwable, Status status) : base(throwable
			)
		{
			this.status = status;
		}

		public CouchbaseLiteException(Exception throwable, int statusCode) : base(throwable
			)
		{
			this.status = new Status(statusCode);
		}

		public virtual Status GetCBLStatus()
		{
			return status;
		}
	}
}
