﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2015-2016 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Jira
// 
//  Dapplo.Jira is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Jira is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Jira. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using Dapplo.Jira.Entities;
using Dapplo.Log.XUnit;
using Dapplo.Log.Facade;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Dapplo.Jira.Tests
{
	public class JiraSessionTests
	{
		// Test against a well known JIRA
		private static readonly Uri TestJiraUri = new Uri("https://greenshot.atlassian.net");

		private readonly JiraApi _jiraApi;

		public JiraSessionTests(ITestOutputHelper testOutputHelper)
		{
			LogSettings.RegisterDefaultLogger<XUnitLogger>(LogLevels.Verbose, testOutputHelper);
			_jiraApi = new JiraApi(TestJiraUri);
		}
		[Fact]
		public async Task TestSession()
		{
			var username = Environment.GetEnvironmentVariable("jira_test_username");
			var password = Environment.GetEnvironmentVariable("jira_test_password");
			if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
			{
				await _jiraApi.StartSessionAsync(username, password);
			}
			var me = await _jiraApi.WhoAmIAsync();
			Assert.Equal(me.Name, username);
			await _jiraApi.EndSessionAsync();
			me = await _jiraApi.WhoAmIAsync();
			Assert.NotEqual(me.Name, username);
		}

    }
}