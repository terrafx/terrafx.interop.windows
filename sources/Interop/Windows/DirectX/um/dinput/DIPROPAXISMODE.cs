// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIPROPAXISMODE
{
    /// <include file='DIPROPAXISMODE.xml' path='doc/member[@name="DIPROPAXISMODE.DIPROPAXISMODE_ABS"]/*' />
    [NativeTypeName("#define DIPROPAXISMODE_ABS 0")]
    public const int DIPROPAXISMODE_ABS = 0;

    /// <include file='DIPROPAXISMODE.xml' path='doc/member[@name="DIPROPAXISMODE.DIPROPAXISMODE_REL"]/*' />
    [NativeTypeName("#define DIPROPAXISMODE_REL 1")]
    public const int DIPROPAXISMODE_REL = 1;
}
