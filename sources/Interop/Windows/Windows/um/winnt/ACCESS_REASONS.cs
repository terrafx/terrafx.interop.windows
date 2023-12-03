// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ACCESS_REASONS.xml' path='doc/member[@name="ACCESS_REASONS"]/*' />
public partial struct ACCESS_REASONS
{
    /// <include file='ACCESS_REASONS.xml' path='doc/member[@name="ACCESS_REASONS.Data"]/*' />
    [NativeTypeName("ACCESS_REASON[32]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _Data_e__FixedBuffer
    {
        public uint e0;
    }
}
