// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ASSOCIATIONELEMENT
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(ASSOCIATIONELEMENT32));
            }
            else
            {
                return (uint)(sizeof(ASSOCIATIONELEMENT64));
            }
        }
    }

    [FieldOffset(0)]
    public ASSOCIATIONELEMENT32 _value32;

    [FieldOffset(0)]
    public ASSOCIATIONELEMENT64 _value64;

    [UnscopedRef]
    public ref ASSOCCLASS ac
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.ac;
            }
            else
            {
                return ref _value64.ac;
            }
        }
    }

    [UnscopedRef]
    public ref HKEY hkClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hkClass;
            }
            else
            {
                return ref _value64.hkClass;
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    [UnscopedRef]
    public ref ushort* pszClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszClass;
            }
            else
            {
                return ref _value64.pszClass;
            }
        }
    }
}
