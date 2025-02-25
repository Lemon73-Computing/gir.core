using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GObject.Integration.Tests;

public abstract class Test
{
    [TestCleanup]
    public void Cleanup()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    protected static void CollectAfter(Action action)
    {
        action();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
