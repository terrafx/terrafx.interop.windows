// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IXAudio2Extension" /> struct.</summary>
public static unsafe partial class IXAudio2ExtensionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IXAudio2Extension" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IXAudio2Extension).GUID, Is.EqualTo(IID_IXAudio2Extension));
    }
}
