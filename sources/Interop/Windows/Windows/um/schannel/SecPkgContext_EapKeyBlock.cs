// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock"]/*' />
public partial struct SecPkgContext_EapKeyBlock
{
    /// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock.rgbKeys"]/*' />
    [NativeTypeName("BYTE[128]")]
    public _rgbKeys_e__FixedBuffer rgbKeys;

    /// <include file='SecPkgContext_EapKeyBlock.xml' path='doc/member[@name="SecPkgContext_EapKeyBlock.rgbIVs"]/*' />
    [NativeTypeName("BYTE[64]")]
    public _rgbIVs_e__FixedBuffer rgbIVs;

    /// <include file='_rgbKeys_e__FixedBuffer.xml' path='doc/member[@name="_rgbKeys_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _rgbKeys_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_rgbIVs_e__FixedBuffer.xml' path='doc/member[@name="_rgbIVs_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _rgbIVs_e__FixedBuffer
    {
        public byte e0;
    }
}
