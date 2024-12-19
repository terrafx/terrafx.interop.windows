// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_PROPERTY_FLAGS.xml' path='doc/member[@name="HTTP_PROPERTY_FLAGS"]/*' />
public partial struct HTTP_PROPERTY_FLAGS
{
    public uint _bitfield;

    /// <include file='HTTP_PROPERTY_FLAGS.xml' path='doc/member[@name="HTTP_PROPERTY_FLAGS.Present"]/*' />
    [NativeTypeName("ULONG : 1")]
    public uint Present
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }
}
