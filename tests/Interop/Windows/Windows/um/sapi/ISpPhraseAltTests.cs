// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISpPhraseAlt" /> struct.</summary>
public static unsafe partial class ISpPhraseAltTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpPhraseAlt" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpPhraseAlt).GUID, Is.EqualTo(IID_ISpPhraseAlt));
    }
}
