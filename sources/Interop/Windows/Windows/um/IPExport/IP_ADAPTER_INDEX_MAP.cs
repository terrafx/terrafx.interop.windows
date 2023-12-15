// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP"]/*' />
public partial struct IP_ADAPTER_INDEX_MAP
{
    /// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP.Index"]/*' />
    [NativeTypeName("ULONG")]
    public uint Index;

    /// <include file='IP_ADAPTER_INDEX_MAP.xml' path='doc/member[@name="IP_ADAPTER_INDEX_MAP.Name"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Name_e__FixedBuffer
    {
        public char e0;
    }
}
