﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Models;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.RouterClients
{
    public class AzureFunctionRuleCredentialTests
    {
        [Test]
        [TestCase(null)]
        [Parallelizable(ParallelScope.All)]
        public void NullFunctionKeyThrowsException(string functionKey)
        {
            Assert.Throws<ArgumentNullException>(() => new AzureFunctionRuleCredential(functionKey));
        }

        [Test]
        [TestCase("")]
        [TestCase("  ")]
        [Parallelizable(ParallelScope.All)]
        public void EmptyFunctionKeyThrowsException(string functionKey)
        {
            Assert.Throws<ArgumentException>(() => new AzureFunctionRuleCredential(functionKey));
        }

        [Test]
        public void NonEmptyFunctionKeyDoesNotThrowsException()
        {
            Assert.DoesNotThrow(() =>
            {
                var funcCredential = new AzureFunctionRuleCredential("functionKey");
                Assert.AreEqual("functionKey", funcCredential.FunctionKey);
            });
        }

        [Test]
        [TestCase("", "")]
        [TestCase("  ", "  ")]
        [TestCase("", "nonempty")]
        [TestCase("nonempty", "  ")]
        [Parallelizable(ParallelScope.All)]
        public void EmptyAppKeyAndClientIdThrowsException(string appKey, string clientId)
        {
            Assert.Throws<ArgumentException>(() => new AzureFunctionRuleCredential(appKey, clientId));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(null, "nonnull")]
        [TestCase("nonnull", null)]
        [Parallelizable(ParallelScope.All)]
        public void NullAppKeyAndClientIdThrowsException(string appKey, string clientId)
        {
            Assert.Throws<ArgumentNullException>(() => new AzureFunctionRuleCredential(appKey, clientId));
        }
    }
}
