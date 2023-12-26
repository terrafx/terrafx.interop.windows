// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="ICoreFrameworkInputView" /> struct.</summary>
public static unsafe partial class ICoreFrameworkInputViewTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICoreFrameworkInputView" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICoreFrameworkInputView).GUID, Is.EqualTo(IID_ICoreFrameworkInputView));
    }
}
