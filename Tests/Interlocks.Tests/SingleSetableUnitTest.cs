// -----------------------------------------------------------------------
// <copyright file="SingleSetableUnitTest.cs" company="Anori Soft">
// Copyright (c) Anori Soft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Diagnostics;

using Bfa.Common.Interlocks;

using NUnit.Framework;

namespace Interlocks.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleSetable_Set_Test()
        {
            var singleSetable = new SingleSetable();
            Assert.False(singleSetable.Set());
            Assert.True(singleSetable.Set());
            Assert.True(singleSetable.Set());
        }

        [Test]
        public void SingleSetable_Set_Value_Test()
        {
            var singleSetable = new SingleSetable();
            Assert.False(singleSetable.Value);
            Assert.False(singleSetable.Set());
            Assert.True(singleSetable.Value);
            Assert.True(singleSetable.Set());
        }

        [Test]
        public void SingleSetable_MultibleCheck_Test()
        {
            var sw = new Stopwatch();
            var singleSetable = new SingleSetable();
            sw.Reset();
            sw.Start();
            for (var i = 0; i < 10000; i++)
            {
                singleSetable.Set();
            }

            sw.Stop();
            Console.WriteLine("ElapsedTicks {0}", sw.ElapsedTicks);

            var singleSetableLock = new SingleSetableLock();
            sw.Reset();
            sw.Start();
            for (var i = 0; i < 10000; i++)
            {
                singleSetableLock.Set();
            }

            sw.Stop();
            Console.WriteLine("ElapsedTicks {0}", sw.ElapsedTicks);
        }
    }
}