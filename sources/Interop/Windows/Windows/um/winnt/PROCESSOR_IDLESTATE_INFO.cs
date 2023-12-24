// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO"]/*' />
public partial struct PROCESSOR_IDLESTATE_INFO
{
    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.TimeCheck"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeCheck;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.DemotePercent"]/*' />
    public byte DemotePercent;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.PromotePercent"]/*' />
    public byte PromotePercent;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.Spare"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Spare_e__FixedBuffer Spare;

    /// <include file='_Spare_e__FixedBuffer.xml' path='doc/member[@name="_Spare_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }
}
