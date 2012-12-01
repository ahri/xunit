﻿namespace Xunit.Abstractions
{
    public interface ITestPassed : ITestMessage
    {
        ITestCase TestCase { get; }

        /// <summary>
        /// Gets the display name of the test.
        /// </summary>
        string DisplayName { get; }
    }
}