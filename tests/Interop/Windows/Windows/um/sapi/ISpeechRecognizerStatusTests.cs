// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISpeechRecognizerStatus" /> struct.</summary>
public static unsafe partial class ISpeechRecognizerStatusTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpeechRecognizerStatus" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpeechRecognizerStatus).GUID, Is.EqualTo(IID_ISpeechRecognizerStatus));
    }
}
