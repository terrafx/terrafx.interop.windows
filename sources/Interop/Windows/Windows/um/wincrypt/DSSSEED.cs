// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DSSSEED.xml' path='doc/member[@name="DSSSEED"]/*' />
public partial struct DSSSEED
{
    /// <include file='DSSSEED.xml' path='doc/member[@name="DSSSEED.counter"]/*' />
    [NativeTypeName("DWORD")]
    public uint counter;

    /// <include file='DSSSEED.xml' path='doc/member[@name="DSSSEED.seed"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _seed_e__FixedBuffer seed;

    /// <include file='_seed_e__FixedBuffer.xml' path='doc/member[@name="_seed_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _seed_e__FixedBuffer
    {
        public byte e0;
    }
}
