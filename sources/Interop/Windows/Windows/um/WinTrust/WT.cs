// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WT
{
    /// <include file='WT.xml' path='doc/member[@name="WT.WT_CURRENT_VERSION"]/*' />
    [NativeTypeName("#define WT_CURRENT_VERSION 0x00000200")]
    public const int WT_CURRENT_VERSION = 0x00000200;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_PROVIDER_DLL_NAME"]/*' />
    [NativeTypeName("#define WT_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
    public const string WT_PROVIDER_DLL_NAME = "WINTRUST.DLL";

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_PROVIDER_CERTTRUST_FUNCTION"]/*' />
    [NativeTypeName("#define WT_PROVIDER_CERTTRUST_FUNCTION L\"WintrustCertificateTrust\"")]
    public const string WT_PROVIDER_CERTTRUST_FUNCTION = "WintrustCertificateTrust";

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_ADD_ACTION_ID_RET_RESULT_FLAG"]/*' />
    [NativeTypeName("#define WT_ADD_ACTION_ID_RET_RESULT_FLAG 0x1")]
    public const int WT_ADD_ACTION_ID_RET_RESULT_FLAG = 0x1;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_TRUSTDBDIALOG_NO_UI_FLAG"]/*' />
    [NativeTypeName("#define WT_TRUSTDBDIALOG_NO_UI_FLAG 0x00000001")]
    public const int WT_TRUSTDBDIALOG_NO_UI_FLAG = 0x00000001;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG"]/*' />
    [NativeTypeName("#define WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG 0x00000002")]
    public const int WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG = 0x00000002;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG"]/*' />
    [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG 0x00000100")]
    public const int WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG = 0x00000100;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG"]/*' />
    [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG 0x00000200")]
    public const int WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG = 0x00000200;
}
