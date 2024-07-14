// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO"]/*' />
public partial struct PROCESSOR_GROUP_INFO
{
    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.MaximumProcessorCount"]/*' />
    public byte MaximumProcessorCount;

    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.ActiveProcessorCount"]/*' />
    public byte ActiveProcessorCount;

    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.Reserved"]/*' />
    [NativeTypeName("BYTE[38]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.ActiveProcessorMask"]/*' />
    [NativeTypeName("KAFFINITY")]
    public nuint ActiveProcessorMask;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(38)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
