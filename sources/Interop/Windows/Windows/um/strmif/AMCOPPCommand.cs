// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand"]/*' />
public partial struct AMCOPPCommand
{
    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.macKDI"]/*' />
    public Guid macKDI;

    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.guidCommandID"]/*' />
    public Guid guidCommandID;

    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.dwSequence"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSequence;

    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.cbSizeData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    /// <include file='AMCOPPCommand.xml' path='doc/member[@name="AMCOPPCommand.CommandData"]/*' />
    [NativeTypeName("BYTE[4056]")]
    public _CommandData_e__FixedBuffer CommandData;

    /// <include file='_CommandData_e__FixedBuffer.xml' path='doc/member[@name="_CommandData_e__FixedBuffer"]/*' />
    [InlineArray(4056)]
    public partial struct _CommandData_e__FixedBuffer
    {
        public byte e0;
    }
}
