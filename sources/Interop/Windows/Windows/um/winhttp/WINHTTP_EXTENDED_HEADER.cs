// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WINHTTP_EXTENDED_HEADER
{
    [NativeTypeName("_WINHTTP_EXTENDED_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winhttp.h:482:5)")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("_WINHTTP_EXTENDED_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winhttp.h:487:5)")]
    public _Anonymous2_e__Union Anonymous2;

    public ref ushort* pwszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pwszName;
        }
    }

    public ref sbyte* pszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszName;
        }
    }

    public ref ushort* pwszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pwszValue;
        }
    }

    public ref sbyte* pszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pszValue;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszName;

        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszName;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszValue;

        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszValue;
    }
}
