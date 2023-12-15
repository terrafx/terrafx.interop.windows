// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_TROUBLESHOOTER_PARAMS_W
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_TROUBLESHOOTER_PARAMS32_W));
            }
            else
            {
                return (uint)(sizeof(SP_TROUBLESHOOTER_PARAMS64_W));
            }
        }
    }

    [FieldOffset(0)]
    public SP_TROUBLESHOOTER_PARAMS32_W _value32;

    [FieldOffset(0)]
    public SP_TROUBLESHOOTER_PARAMS64_W _value64;

    [UnscopedRef]
    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader);
            }
            else
            {
                return ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader);
            }
        }
    }

    [NativeTypeName("WCHAR[260]")]
    [UnscopedRef]
    public Span<char> ChmFile
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.ChmFile;
            }
            else
            {
                return _value64.ChmFile;
            }
        }
    }

    [NativeTypeName("WCHAR[260]")]
    [UnscopedRef]
    public Span<char> HtmlTroubleShooter
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.HtmlTroubleShooter;
            }
            else
            {
                return _value64.HtmlTroubleShooter;
            }
        }
    }
}
