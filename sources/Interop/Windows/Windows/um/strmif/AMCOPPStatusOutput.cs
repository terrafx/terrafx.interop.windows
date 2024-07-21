// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput"]/*' />
public partial struct AMCOPPStatusOutput
{
    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.macKDI"]/*' />
    public Guid macKDI;

    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.cbSizeData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.COPPStatus"]/*' />
    [NativeTypeName("BYTE[4076]")]
    public _COPPStatus_e__FixedBuffer COPPStatus;

    /// <include file='_COPPStatus_e__FixedBuffer.xml' path='doc/member[@name="_COPPStatus_e__FixedBuffer"]/*' />
    [InlineArray(4076)]
    public partial struct _COPPStatus_e__FixedBuffer
    {
        public byte e0;
    }
}
