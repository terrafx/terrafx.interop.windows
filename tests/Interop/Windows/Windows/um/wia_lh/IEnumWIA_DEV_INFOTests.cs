// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IEnumWIA_DEV_INFO" /> struct.</summary>
public static unsafe partial class IEnumWIA_DEV_INFOTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumWIA_DEV_INFO" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumWIA_DEV_INFO).GUID, Is.EqualTo(IID_IEnumWIA_DEV_INFO));
    }
}
