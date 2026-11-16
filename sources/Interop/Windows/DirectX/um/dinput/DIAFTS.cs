// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIAFTS
{
    /// <include file='DIAFTS.xml' path='doc/member[@name="DIAFTS.DIAFTS_NEWDEVICELOW"]/*' />
    [NativeTypeName("#define DIAFTS_NEWDEVICELOW 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICELOW = 0xFFFFFFFF;

    /// <include file='DIAFTS.xml' path='doc/member[@name="DIAFTS.DIAFTS_NEWDEVICEHIGH"]/*' />
    [NativeTypeName("#define DIAFTS_NEWDEVICEHIGH 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICEHIGH = 0xFFFFFFFF;

    /// <include file='DIAFTS.xml' path='doc/member[@name="DIAFTS.DIAFTS_UNUSEDDEVICELOW"]/*' />
    [NativeTypeName("#define DIAFTS_UNUSEDDEVICELOW 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICELOW = 0x00000000;

    /// <include file='DIAFTS.xml' path='doc/member[@name="DIAFTS.DIAFTS_UNUSEDDEVICEHIGH"]/*' />
    [NativeTypeName("#define DIAFTS_UNUSEDDEVICEHIGH 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICEHIGH = 0x00000000;
}
