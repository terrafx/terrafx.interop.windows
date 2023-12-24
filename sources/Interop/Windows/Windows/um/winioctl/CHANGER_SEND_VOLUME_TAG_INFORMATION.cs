// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CHANGER_SEND_VOLUME_TAG_INFORMATION.xml' path='doc/member[@name="CHANGER_SEND_VOLUME_TAG_INFORMATION"]/*' />
public partial struct CHANGER_SEND_VOLUME_TAG_INFORMATION
{
    /// <include file='CHANGER_SEND_VOLUME_TAG_INFORMATION.xml' path='doc/member[@name="CHANGER_SEND_VOLUME_TAG_INFORMATION.StartingElement"]/*' />
    public CHANGER_ELEMENT StartingElement;

    /// <include file='CHANGER_SEND_VOLUME_TAG_INFORMATION.xml' path='doc/member[@name="CHANGER_SEND_VOLUME_TAG_INFORMATION.ActionCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint ActionCode;

    /// <include file='CHANGER_SEND_VOLUME_TAG_INFORMATION.xml' path='doc/member[@name="CHANGER_SEND_VOLUME_TAG_INFORMATION.VolumeIDTemplate"]/*' />
    [NativeTypeName("BYTE[40]")]
    public _VolumeIDTemplate_e__FixedBuffer VolumeIDTemplate;

    /// <include file='_VolumeIDTemplate_e__FixedBuffer.xml' path='doc/member[@name="_VolumeIDTemplate_e__FixedBuffer"]/*' />
    [InlineArray(40)]
    public partial struct _VolumeIDTemplate_e__FixedBuffer
    {
        public byte e0;
    }
}
