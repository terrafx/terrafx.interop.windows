// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DEVICE
{
    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_STATE_ACTIVE"]/*' />
    [NativeTypeName("#define DEVICE_STATE_ACTIVE 0x00000001")]
    public const int DEVICE_STATE_ACTIVE = 0x00000001;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_STATE_DISABLED"]/*' />
    [NativeTypeName("#define DEVICE_STATE_DISABLED 0x00000002")]
    public const int DEVICE_STATE_DISABLED = 0x00000002;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_STATE_NOTPRESENT"]/*' />
    [NativeTypeName("#define DEVICE_STATE_NOTPRESENT 0x00000004")]
    public const int DEVICE_STATE_NOTPRESENT = 0x00000004;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_STATE_UNPLUGGED"]/*' />
    [NativeTypeName("#define DEVICE_STATE_UNPLUGGED 0x00000008")]
    public const int DEVICE_STATE_UNPLUGGED = 0x00000008;

    /// <include file='DEVICE.xml' path='doc/member[@name="DEVICE.DEVICE_STATEMASK_ALL"]/*' />
    [NativeTypeName("#define DEVICE_STATEMASK_ALL 0x0000000f")]
    public const int DEVICE_STATEMASK_ALL = 0x0000000f;
}
