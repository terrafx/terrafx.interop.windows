// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY"]/*' />
public partial struct GROUP_AFFINITY
{
    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Mask"]/*' />
    [NativeTypeName("KAFFINITY")]
    public nuint Mask;

    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Group"]/*' />
    [NativeTypeName("WORD")]
    public ushort Group;

    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Reserved"]/*' />
    [NativeTypeName("WORD[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ushort e0;
    }
}
