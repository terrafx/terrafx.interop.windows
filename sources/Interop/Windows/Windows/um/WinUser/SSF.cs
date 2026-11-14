// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SSF
{
    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_SOUNDSENTRYON"]/*' />
    [NativeTypeName("#define SSF_SOUNDSENTRYON 0x00000001")]
    public const int SSF_SOUNDSENTRYON = 0x00000001;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_AVAILABLE"]/*' />
    [NativeTypeName("#define SSF_AVAILABLE 0x00000002")]
    public const int SSF_AVAILABLE = 0x00000002;

    /// <include file='SSF.xml' path='doc/member[@name="SSF.SSF_INDICATOR"]/*' />
    [NativeTypeName("#define SSF_INDICATOR 0x00000004")]
    public const int SSF_INDICATOR = 0x00000004;
}
