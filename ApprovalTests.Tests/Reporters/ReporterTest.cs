﻿using System;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace ApprovalTests.Tests.Reporters
{
    [TestFixture]
    public class ReporterTest
    {
        [Test]
        public void Testname()
        {
            var old = Environment.GetEnvironmentVariable(NCrunchReporter.EnviromentVariable);
            Environment.SetEnvironmentVariable(NCrunchReporter.EnviromentVariable, "1");
            Assert.IsTrue(NCrunchReporter.INSTANCE.IsWorkingInThisEnvironment("a.txt"));
            Environment.SetEnvironmentVariable(NCrunchReporter.EnviromentVariable, old);
        }
    }
}