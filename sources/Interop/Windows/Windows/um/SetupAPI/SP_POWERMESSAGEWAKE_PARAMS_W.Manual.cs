// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_POWERMESSAGEWAKE_PARAMS_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_POWERMESSAGEWAKE_PARAMS32_W));
            }
            else
            {
                return (uint)(sizeof(SP_POWERMESSAGEWAKE_PARAMS64_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_POWERMESSAGEWAKE_PARAMS32_W _value32;

    [FieldOffset(0)]
    public SP_POWERMESSAGEWAKE_PARAMS64_W _value64;

    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader), 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader), 1));
            }
        }
    }

    [NativeTypeName("WCHAR [512]")]
    public Span<ushort> PowerMessageWake
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.PowerMessageWake[0], 512);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.PowerMessageWake[0], 512);
            }
        }
    }
}
