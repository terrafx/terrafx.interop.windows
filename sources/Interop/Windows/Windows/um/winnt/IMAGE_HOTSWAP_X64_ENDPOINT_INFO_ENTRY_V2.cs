// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2"]/*' />
public partial struct IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2
{
    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.Common"]/*' />
    public IMAGE_HOTSWAP_ENDPOINT_INFO_ENTRY_COMMON Common;

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.ArgRegs"]/*' />
    [NativeTypeName("IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG[4]")]
    public _ArgRegs_e__FixedBuffer ArgRegs;

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.ArgStackSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ArgStackSize;

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.RetReg"]/*' />
    public IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG RetReg;

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_ENTRY_V2.Name"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_ArgRegs_e__FixedBuffer.xml' path='doc/member[@name="_ArgRegs_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _ArgRegs_e__FixedBuffer
    {
        public IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG e0;
    }

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    public partial struct _Name_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
