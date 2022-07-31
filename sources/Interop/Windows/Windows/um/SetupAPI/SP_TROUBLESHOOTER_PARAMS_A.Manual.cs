// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_TROUBLESHOOTER_PARAMS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_TROUBLESHOOTER_PARAMS32_A));
            }
            else
            {
                return (uint)(sizeof(SP_TROUBLESHOOTER_PARAMS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_TROUBLESHOOTER_PARAMS32_A _value32;

    [FieldOffset(0)]
    public SP_TROUBLESHOOTER_PARAMS64_A _value64;

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

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> ChmFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.ChmFile[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.ChmFile[0], 260);
            }
        }
    }

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> HtmlTroubleShooter
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.HtmlTroubleShooter[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.HtmlTroubleShooter[0], 260);
            }
        }
    }
}
