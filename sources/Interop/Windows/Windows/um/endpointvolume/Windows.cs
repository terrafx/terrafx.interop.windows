// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENDPOINT_HARDWARE_SUPPORT_VOLUME"]/*' />
    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_VOLUME 0x00000001")]
    public const int ENDPOINT_HARDWARE_SUPPORT_VOLUME = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENDPOINT_HARDWARE_SUPPORT_MUTE"]/*' />
    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_MUTE 0x00000002")]
    public const int ENDPOINT_HARDWARE_SUPPORT_MUTE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENDPOINT_HARDWARE_SUPPORT_METER"]/*' />
    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_METER 0x00000004")]
    public const int ENDPOINT_HARDWARE_SUPPORT_METER = 0x00000004;
}
