// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ClipboardHistoryItemsResultStatus.xml' path='doc/member[@name="ClipboardHistoryItemsResultStatus"]/*' />
public enum ClipboardHistoryItemsResultStatus
{
    /// <include file='ClipboardHistoryItemsResultStatus.xml' path='doc/member[@name="ClipboardHistoryItemsResultStatus.ClipboardHistoryItemsResultStatus_Success"]/*' />
    ClipboardHistoryItemsResultStatus_Success = 0,

    /// <include file='ClipboardHistoryItemsResultStatus.xml' path='doc/member[@name="ClipboardHistoryItemsResultStatus.ClipboardHistoryItemsResultStatus_AccessDenied"]/*' />
    ClipboardHistoryItemsResultStatus_AccessDenied = 1,

    /// <include file='ClipboardHistoryItemsResultStatus.xml' path='doc/member[@name="ClipboardHistoryItemsResultStatus.ClipboardHistoryItemsResultStatus_ClipboardHistoryDisabled"]/*' />
    ClipboardHistoryItemsResultStatus_ClipboardHistoryDisabled = 2,
}
