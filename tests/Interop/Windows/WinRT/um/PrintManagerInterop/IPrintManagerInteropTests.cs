// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IPrintManagerInterop" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IPrintManagerInteropTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPrintManagerInterop" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPrintManagerInterop).GUID, Is.EqualTo(IID_IPrintManagerInterop));
    }
}
