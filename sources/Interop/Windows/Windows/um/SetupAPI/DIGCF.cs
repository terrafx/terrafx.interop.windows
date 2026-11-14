// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DIGCF
{
    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_DEFAULT"]/*' />
    [NativeTypeName("#define DIGCF_DEFAULT 0x00000001")]
    public const int DIGCF_DEFAULT = 0x00000001;

    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_PRESENT"]/*' />
    [NativeTypeName("#define DIGCF_PRESENT 0x00000002")]
    public const int DIGCF_PRESENT = 0x00000002;

    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_ALLCLASSES"]/*' />
    [NativeTypeName("#define DIGCF_ALLCLASSES 0x00000004")]
    public const int DIGCF_ALLCLASSES = 0x00000004;

    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_PROFILE"]/*' />
    [NativeTypeName("#define DIGCF_PROFILE 0x00000008")]
    public const int DIGCF_PROFILE = 0x00000008;

    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_DEVICEINTERFACE"]/*' />
    [NativeTypeName("#define DIGCF_DEVICEINTERFACE 0x00000010")]
    public const int DIGCF_DEVICEINTERFACE = 0x00000010;

    /// <include file='DIGCF.xml' path='doc/member[@name="DIGCF.DIGCF_INTERFACEDEVICE"]/*' />
    [NativeTypeName("#define DIGCF_INTERFACEDEVICE DIGCF_DEVICEINTERFACE")]
    public const int DIGCF_INTERFACEDEVICE = 0x00000010;
}
