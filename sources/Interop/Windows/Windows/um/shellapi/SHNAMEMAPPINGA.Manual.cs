// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

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
    public ref sbyte* pszOldPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszOldPath;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszOldPath;
            }
        }
    }

    [NativeTypeName("LPSTR")]
    public ref sbyte* pszNewPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszNewPath;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszNewPath;
            }
        }
    }

    public ref int cchOldPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cchOldPath, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cchOldPath, 1));
            }
        }
    }

    public ref int cchNewPath
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cchNewPath, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cchNewPath, 1));
            }
        }
    }
}
