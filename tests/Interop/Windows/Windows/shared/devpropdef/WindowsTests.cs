// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates device property key comparisons.</summary>
    [Test]
    public static void IsEqualDevPropKeyTest()
    {
        DEVPROPKEY left = new() { fmtid = new Guid(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), pid = 12 };
        DEVPROPKEY same = left;
        DEVPROPKEY different = new() { fmtid = left.fmtid, pid = 13 };

        Assert.That(IsEqualDevPropKey(left, same), Is.True);
        Assert.That(left == same, Is.True);
        Assert.That(left != different, Is.True);
        Assert.That(IsEqualDevPropKey(left, different), Is.False);
    }

    /// <summary>Validates locale name comparisons for device property keys.</summary>
    [Test]
    public static void IsEqualLocaleNameTest()
    {
        const string lowerCase = "en-US";
        const string upperCase = "EN-us";

        fixed (char* lower = lowerCase)
        fixed (char* upper = upperCase)
        {
            Assert.That(IsEqualLocaleName(lower, upper), Is.True);
            Assert.That(IsEqualLocaleName(lower, null), Is.False);
            Assert.That(IsEqualLocaleName(null, null), Is.True);
        }
    }

    /// <summary>Validates composite device property key comparisons.</summary>
    [Test]
    public static void IsEqualDevPropCompKeyTest()
    {
        const string lowerCase = "en-US";
        const string upperCase = "EN-us";

        fixed (char* lower = lowerCase)
        fixed (char* upper = upperCase)
        {
            DEVPROPCOMPKEY left = new() { Key = new DEVPROPKEY { fmtid = Guid.Empty, pid = 1 }, Store = DEVPROPSTORE.DEVPROP_STORE_SYSTEM, LocaleName = lower };
            DEVPROPCOMPKEY same = new() { Key = left.Key, Store = left.Store, LocaleName = upper };
            DEVPROPCOMPKEY different = new() { Key = left.Key, Store = left.Store, LocaleName = null };

            Assert.That(IsEqualDevPropCompKey(left, same), Is.True);
            Assert.That(left == same, Is.True);
            Assert.That(left != different, Is.True);
        }
    }
}
