// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.E;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates HRESULT conversion and helper macros.</summary>
    [Test]
    public static void WinErrorMacrosTest()
    {
        Assert.That((int)__HRESULT_FROM_WIN32(5), Is.EqualTo((int)HRESULT_FROM_WIN32(5)));
        Assert.That((int)__HRESULT_FROM_WIN32(-5), Is.EqualTo(-5));

        Assert.That((int)HRESULT_FROM_SETUPAPI(5), Is.EqualTo((int)HRESULT_FROM_WIN32(5)));
        Assert.That((int)HRESULT_FROM_SETUPAPI(0xE0000001), Is.EqualTo(unchecked((int)0x800F0001)));
        Assert.That((int)__HRESULT_FROM_SETUPAPI(0xE0000001), Is.EqualTo(unchecked((int)0x800F0001)));

        Assert.That((int)FILTER_HRESULT_FROM_FLT_NTSTATUS(unchecked((int)0xC01C0001)), Is.EqualTo(unchecked((int)0x801F0001)));
        Assert.That(IS_CAMERA_ERROR_CODE((HRESULT)E_CAMERA_ERROR_MIN), Is.True);
        Assert.That(IS_CAMERA_ERROR_CODE((HRESULT)(E_CAMERA_ERROR_MAX + 1)), Is.False);

        const int scode = unchecked((int)0x80000001);
        Assert.That(GetScode((HRESULT)scode), Is.EqualTo(scode));
        Assert.That((int)ResultFromScode(scode), Is.EqualTo(scode));
        Assert.That((int)PropagateResult((HRESULT)(-1), scode), Is.EqualTo(scode));
    }
}
