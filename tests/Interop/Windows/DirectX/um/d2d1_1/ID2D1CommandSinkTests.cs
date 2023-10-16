// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID2D1CommandSink" /> struct.</summary>
public static unsafe partial class ID2D1CommandSinkTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID2D1CommandSink" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID2D1CommandSink).GUID, Is.EqualTo(IID_ID2D1CommandSink));
    }
}
