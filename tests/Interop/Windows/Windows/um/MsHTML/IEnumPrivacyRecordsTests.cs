// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IEnumPrivacyRecords" /> struct.</summary>
public static unsafe partial class IEnumPrivacyRecordsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumPrivacyRecords" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumPrivacyRecords).GUID, Is.EqualTo(IID_IEnumPrivacyRecords));
    }
}
