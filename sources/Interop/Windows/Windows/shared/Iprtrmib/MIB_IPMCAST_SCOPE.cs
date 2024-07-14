// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE"]/*' />
public partial struct MIB_IPMCAST_SCOPE
{
    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwGroupAddress"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGroupAddress;

    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwGroupMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGroupMask;

    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.snNameBuffer"]/*' />
    [NativeTypeName("SCOPE_NAME_BUFFER")]
    public _snNameBuffer_e__FixedBuffer snNameBuffer;

    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStatus;

    /// <include file='_snNameBuffer_e__FixedBuffer.xml' path='doc/member[@name="_snNameBuffer_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _snNameBuffer_e__FixedBuffer
    {
        public char e0;
    }
}
