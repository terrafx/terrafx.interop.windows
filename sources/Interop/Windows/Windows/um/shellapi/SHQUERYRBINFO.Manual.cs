// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHQUERYRBINFO
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHQUERYRBINFO32));
            }
            else
            {
                return (uint)(sizeof(SHQUERYRBINFO64));
            }
        }
    }

    [FieldOffset(0)]
    public SHQUERYRBINFO32 _value32;

    [FieldOffset(0)]
    public SHQUERYRBINFO64 _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [NativeTypeName("long long")]
    [UnscopedRef]
    public ref long i64Size
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.i64Size;
            }
            else
            {
                return ref _value64.i64Size;
            }
        }
    }

    [NativeTypeName("long long")]
    [UnscopedRef]
    public ref long i64NumItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.i64NumItems;
            }
            else
            {
                return ref _value64.i64NumItems;
            }
        }
    }
}
