// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='DiaAddressMapEntry.xml' path='doc/member[@name="DiaAddressMapEntry"]/*' />
public partial struct DiaAddressMapEntry
{
    /// <include file='DiaAddressMapEntry.xml' path='doc/member[@name="DiaAddressMapEntry.rva"]/*' />
    [NativeTypeName("DWORD")]
    public uint rva;

    /// <include file='DiaAddressMapEntry.xml' path='doc/member[@name="DiaAddressMapEntry.rvaTo"]/*' />
    [NativeTypeName("DWORD")]
    public uint rvaTo;
}
