// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT"]/*' />
public partial struct SCM_PD_PASSTHROUGH_INVDIMM_INPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.Opcode"]/*' />
    [NativeTypeName("DWORD")]
    public uint Opcode;

    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.OpcodeParametersLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint OpcodeParametersLength;

    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.OpcodeParameters"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _OpcodeParameters_e__FixedBuffer OpcodeParameters;

    /// <include file='_OpcodeParameters_e__FixedBuffer.xml' path='doc/member[@name="_OpcodeParameters_e__FixedBuffer"]/*' />
    public partial struct _OpcodeParameters_e__FixedBuffer
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
