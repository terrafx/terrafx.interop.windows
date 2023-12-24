// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION"]/*' />
public partial struct SILOOBJECT_BASIC_INFORMATION
{
    /// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION.SiloId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SiloId;

    /// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION.SiloParentId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SiloParentId;

    /// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION.NumberOfProcesses"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfProcesses;

    /// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION.IsInServerSilo"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IsInServerSilo;

    /// <include file='SILOOBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="SILOOBJECT_BASIC_INFORMATION.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
