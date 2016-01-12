﻿/*
	Dapplo - building blocks for desktop applications
	Copyright (C) 2015-2016 Dapplo

	For more information see: http://dapplo.net/
	Dapplo repositories are hosted on GitHub: https://github.com/dapplo

	This file is part of Dapplo.Jira

	Dapplo.Jira is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	Dapplo.Exchange is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with Dapplo.Jira. If not, see <http://www.gnu.org/licenses/>.
 */


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dapplo.Jira.Tests
{
	[TestClass]
	public class JiraTests
	{
		[TestMethod]
		public async Task TestCreateAndInitializeAsync()
		{
			var jiraApi = await JiraApi.CreateAndInitializeAsync(new Uri("https://greenshot.atlassian.net"));
			Assert.IsNotNull(jiraApi);
			Assert.IsNotNull(jiraApi.JiraVersion);
			Assert.IsNotNull(jiraApi.ServerTitle);
			Debug.WriteLine($"Version {jiraApi.JiraVersion} - Title {jiraApi.ServerTitle}");
		}
	}
}