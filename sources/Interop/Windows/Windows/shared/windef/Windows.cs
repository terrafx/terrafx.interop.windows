// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HFILE_ERROR"]/*' />
    [NativeTypeName("#define HFILE_ERROR ((HFILE)-1)")]
    public const int HFILE_ERROR = ((int)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APP_LOCAL_DEVICE_ID_SIZE"]/*' />
    [NativeTypeName("#define APP_LOCAL_DEVICE_ID_SIZE 32")]
    public const int APP_LOCAL_DEVICE_ID_SIZE = 32;
}
