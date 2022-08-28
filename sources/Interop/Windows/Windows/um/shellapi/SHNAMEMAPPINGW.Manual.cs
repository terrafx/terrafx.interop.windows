// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHNAMEMAPPINGW
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHNAMEMAPPING32W));
            }
            else
            {
                return (uint)(sizeof(SHNAMEMAPPING64W));
            }
        }
    }

    [FieldOffset(0)]
    public SHNAMEMAPPING32W _value32;

    [FieldOffset(0)]
    public SHNAMEMAPPING64W _value64;

    [NativeTypeName("LPWSTR")]
    [UnscopedRef]
    public ref ushort* pszOldPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszOldPath;
            }
            else
            {
                return ref _value64.pszOldPath;
            }
        }
    }

    [NativeTypeName("LPWSTR")]
    [UnscopedRef]
    public ref ushort* pszNewPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszNewPath;
            }
            else
            {
                return ref _value64.pszNewPath;
            }
        }
    }

    [UnscopedRef]
    public ref int cchOldPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cchOldPath;
            }
            else
            {
                return ref _value64.cchOldPath;
            }
        }
    }

    [UnscopedRef]
    public ref int cchNewPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cchNewPath;
            }
            else
            {
                return ref _value64.cchNewPath;
            }
        }
    }
}
