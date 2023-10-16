// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DVD_MultichannelAudioAttributes.xml' path='doc/member[@name="DVD_MultichannelAudioAttributes"]/*' />
public partial struct DVD_MultichannelAudioAttributes
{
    /// <include file='DVD_MultichannelAudioAttributes.xml' path='doc/member[@name="DVD_MultichannelAudioAttributes.Info"]/*' />
    [NativeTypeName("DVD_MUA_MixingInfo[8]")]
    public _Info_e__FixedBuffer Info;

    /// <include file='DVD_MultichannelAudioAttributes.xml' path='doc/member[@name="DVD_MultichannelAudioAttributes.Coeff"]/*' />
    [NativeTypeName("DVD_MUA_Coeff[8]")]
    public _Coeff_e__FixedBuffer Coeff;

    /// <include file='_Info_e__FixedBuffer.xml' path='doc/member[@name="_Info_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Info_e__FixedBuffer
    {
        public DVD_MUA_MixingInfo e0;
    }

    /// <include file='_Coeff_e__FixedBuffer.xml' path='doc/member[@name="_Coeff_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Coeff_e__FixedBuffer
    {
        public DVD_MUA_Coeff e0;
    }
}
