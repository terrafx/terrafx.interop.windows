// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUIViewSettingsPreferredInteractionMode
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0xE2, 0x6D, 0x42,
                0xEC, 0x82,
                0x61, 0x5F,
                0xBA,
                0xD4,
                0x19,
                0xB2,
                0xD0,
                0xD3,
                0xCF,
                0x35
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
