#region Dapplo 2017-2018 - GNU Lesser General Public License

// Dapplo - building blocks for .NET applications
// Copyright (C) 2017-2018 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Dapplo.Jira
// 
// Dapplo.Jira is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Dapplo.Jira is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Dapplo.Jira. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#endregion

namespace Dapplo.Jira.Query
{
	/// <summary>
	///     An interface for a date time calculations clause
	/// </summary>
	public interface IDatetimeClause
	{
		/// <summary>
		/// Is the queried timestamp after the specified timestamp?
		/// </summary>
		IDatetimeClauseWithoutValue After { get; }

		/// <summary>
		///  Is the queried timestamp after or on the specified timestamp?
		/// </summary>
		IDatetimeClauseWithoutValue AfterOrOn { get; }
		/// <summary>
		///  Is the queried timestamp before the specified timestamp?
		/// </summary>
		IDatetimeClauseWithoutValue Before { get; }
		/// <summary>
		///  Is the queried timestamp before or on the specified timestamp?
		/// </summary>
		IDatetimeClauseWithoutValue BeforeOrOn { get; }
		/// <summary>
		///  Is the queried timestamp the same as the specified timestamp?
		/// </summary>
		IDatetimeClauseWithoutValue On { get; }
	}
}