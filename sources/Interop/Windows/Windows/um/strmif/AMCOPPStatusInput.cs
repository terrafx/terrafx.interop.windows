// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput"]/*' />
public partial struct AMCOPPStatusInput
{
    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.rApp"]/*' />
    public Guid rApp;

    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.guidStatusRequestID"]/*' />
    public Guid guidStatusRequestID;

    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.dwSequence"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSequence;

    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.cbSizeData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    /// <include file='AMCOPPStatusInput.xml' path='doc/member[@name="AMCOPPStatusInput.StatusData"]/*' />
    [NativeTypeName("BYTE[4056]")]
    public _StatusData_e__FixedBuffer StatusData;

    /// <include file='_StatusData_e__FixedBuffer.xml' path='doc/member[@name="_StatusData_e__FixedBuffer"]/*' />
    [InlineArray(4056)]
    public partial struct _StatusData_e__FixedBuffer
    {
        public byte e0;
    }
}
