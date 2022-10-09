// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue"]/*' />
public unsafe partial struct DiaTagValue
{
    /// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue.value"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte value[16];

    /// <include file='DiaTagValue.xml' path='doc/member[@name="DiaTagValue.valueSizeBytes"]/*' />
    public byte valueSizeBytes;
}
