// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IPV6_ADDRESS_EX
{
    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_port"]/*' />
    public ushort sin6_port;

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_flowinfo"]/*' />
    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_addr"]/*' />
    [NativeTypeName("USHORT[8]")]
    public _sin6_addr_e__FixedBuffer sin6_addr;

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_scope_id"]/*' />
    [NativeTypeName("ULONG")]
    public uint sin6_scope_id;

    /// <include file='_sin6_addr_e__FixedBuffer.xml' path='doc/member[@name="_sin6_addr_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(8)]
    public partial struct _sin6_addr_e__FixedBuffer
    {
        public ushort e0;
    }
}
