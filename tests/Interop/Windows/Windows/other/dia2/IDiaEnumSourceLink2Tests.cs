// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDiaEnumSourceLink2" /> struct.</summary>
public static unsafe partial class IDiaEnumSourceLink2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaEnumSourceLink2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaEnumSourceLink2).GUID, Is.EqualTo(IID_IDiaEnumSourceLink2));
    }
}
