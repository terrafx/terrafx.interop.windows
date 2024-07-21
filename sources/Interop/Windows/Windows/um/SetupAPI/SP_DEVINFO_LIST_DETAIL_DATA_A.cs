// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVINFO_LIST_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVINFO_LIST_DETAIL_DATA_A"]/*' />
public partial struct SP_DEVINFO_LIST_DETAIL_DATA_A
{
    /// <include file='SP_DEVINFO_LIST_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVINFO_LIST_DETAIL_DATA_A.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVINFO_LIST_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVINFO_LIST_DETAIL_DATA_A.ClassGuid"]/*' />
    public Guid ClassGuid;

    /// <include file='SP_DEVINFO_LIST_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVINFO_LIST_DETAIL_DATA_A.RemoteMachineHandle"]/*' />
    public HANDLE RemoteMachineHandle;

    /// <include file='SP_DEVINFO_LIST_DETAIL_DATA_A.xml' path='doc/member[@name="SP_DEVINFO_LIST_DETAIL_DATA_A.RemoteMachineName"]/*' />
    [NativeTypeName("CHAR[263]")]
    public _RemoteMachineName_e__FixedBuffer RemoteMachineName;

    /// <include file='_RemoteMachineName_e__FixedBuffer.xml' path='doc/member[@name="_RemoteMachineName_e__FixedBuffer"]/*' />
    [InlineArray(263)]
    public partial struct _RemoteMachineName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
