// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WAIT
{
    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_TIMEOUT"]/*' />
    [NativeTypeName("#define WAIT_TIMEOUT 258L")]
    public const int WAIT_TIMEOUT = 258;
}
