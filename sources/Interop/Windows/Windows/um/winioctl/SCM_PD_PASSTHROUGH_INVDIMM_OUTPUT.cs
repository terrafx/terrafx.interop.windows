// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT"]/*' />
public partial struct SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.GeneralStatus"]/*' />
    [NativeTypeName("WORD")]
    public ushort GeneralStatus;

    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.ExtendedStatus"]/*' />
    [NativeTypeName("WORD")]
    public ushort ExtendedStatus;

    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.OutputDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint OutputDataLength;

    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.OutputData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _OutputData_e__FixedBuffer OutputData;

    /// <include file='_OutputData_e__FixedBuffer.xml' path='doc/member[@name="_OutputData_e__FixedBuffer"]/*' />
    public partial struct _OutputData_e__FixedBuffer
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
