﻿using Atata;
using NUnit.Framework;

namespace $safeprojectname$
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class UITestFixture
{
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
