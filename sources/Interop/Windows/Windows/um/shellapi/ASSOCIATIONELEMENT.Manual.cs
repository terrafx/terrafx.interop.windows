// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

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

    public ref ASSOCCLASS ac
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.ac, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.ac, 1));
            }
        }
    }

    public ref HKEY hkClass
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hkClass, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hkClass, 1));
            }
        }
    }

    [NativeTypeName("PCWSTR")]
    public ref ushort* pszClass
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszClass;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszClass;
            }
        }
    }
}
