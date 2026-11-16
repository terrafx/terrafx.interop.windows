// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DBG
{
    /// <include file='DBG.xml' path='doc/member[@name="DBG.DBG_UNABLE_TO_PROVIDE_HANDLE"]/*' />
    [NativeTypeName("#define DBG_UNABLE_TO_PROVIDE_HANDLE ((NTSTATUS)0x40010002L)")]
    public const int DBG_UNABLE_TO_PROVIDE_HANDLE = ((int)(0x40010002));

    /// <include file='DBG.xml' path='doc/member[@name="DBG.DBG_NO_STATE_CHANGE"]/*' />
    [NativeTypeName("#define DBG_NO_STATE_CHANGE ((NTSTATUS)0xC0010001L)")]
    public const int DBG_NO_STATE_CHANGE = unchecked((int)(0xC0010001));

    /// <include file='DBG.xml' path='doc/member[@name="DBG.DBG_APP_NOT_IDLE"]/*' />
    [NativeTypeName("#define DBG_APP_NOT_IDLE ((NTSTATUS)0xC0010002L)")]
    public const int DBG_APP_NOT_IDLE = unchecked((int)(0xC0010002));
}
