// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHNAMEMAPPINGA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHNAMEMAPPING32A));
            }
            else
            {
                return (uint)(sizeof(SHNAMEMAPPING64A));
            }
        }
    }

    [FieldOffset(0)]
    public SHNAMEMAPPING32A _value32;

    [FieldOffset(0)]
    public SHNAMEMAPPING64A _value64;

    [NativeTypeName("LPSTR")]
    [UnscopedRef]
    public ref sbyte* pszOldPath
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

    [NativeTypeName("LPSTR")]
    [UnscopedRef]
    public ref sbyte* pszNewPath
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
