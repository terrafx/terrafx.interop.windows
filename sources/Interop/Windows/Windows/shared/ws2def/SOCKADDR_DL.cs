// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL"]/*' />
public partial struct SOCKADDR_DL
{
    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_family"]/*' />
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sdl_family;

    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_data"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public _sdl_data_e__FixedBuffer sdl_data;

    /// <include file='SOCKADDR_DL.xml' path='doc/member[@name="SOCKADDR_DL.sdl_zero"]/*' />
    [NativeTypeName("UCHAR[4]")]
    public _sdl_zero_e__FixedBuffer sdl_zero;

    /// <include file='_sdl_data_e__FixedBuffer.xml' path='doc/member[@name="_sdl_data_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _sdl_data_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_sdl_zero_e__FixedBuffer.xml' path='doc/member[@name="_sdl_zero_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _sdl_zero_e__FixedBuffer
    {
        public byte e0;
    }
}
