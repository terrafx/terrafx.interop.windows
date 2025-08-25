// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPATCHER_CONTEXT_NONVOLREG_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_NONVOLREG_ARM64"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct DISPATCHER_CONTEXT_NONVOLREG_ARM64
{
    /// <include file='DISPATCHER_CONTEXT_NONVOLREG_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_NONVOLREG_ARM64.Buffer"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("BYTE[152]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='DISPATCHER_CONTEXT_NONVOLREG_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_NONVOLREG_ARM64.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L7103_C5")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.GpNvRegs"]/*' />
    [UnscopedRef]
    public Span<ulong> GpNvRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.GpNvRegs;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FpNvRegs"]/*' />
    [UnscopedRef]
    public Span<double> FpNvRegs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.FpNvRegs;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.GpNvRegs"]/*' />
        [NativeTypeName("DWORD64[11]")]
        public _GpNvRegs_e__FixedBuffer GpNvRegs;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FpNvRegs"]/*' />
        [NativeTypeName("double[8]")]
        public _FpNvRegs_e__FixedBuffer FpNvRegs;

        /// <include file='_GpNvRegs_e__FixedBuffer.xml' path='doc/member[@name="_GpNvRegs_e__FixedBuffer"]/*' />
        [InlineArray(11)]
        public partial struct _GpNvRegs_e__FixedBuffer
        {
            public ulong e0;
        }

        /// <include file='_FpNvRegs_e__FixedBuffer.xml' path='doc/member[@name="_FpNvRegs_e__FixedBuffer"]/*' />
        [InlineArray(8)]
        public partial struct _FpNvRegs_e__FixedBuffer
        {
            public double e0;
        }
    }

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    [InlineArray(152)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
