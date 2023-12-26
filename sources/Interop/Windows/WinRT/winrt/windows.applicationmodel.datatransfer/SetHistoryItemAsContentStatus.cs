// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SetHistoryItemAsContentStatus.xml' path='doc/member[@name="SetHistoryItemAsContentStatus"]/*' />
public enum SetHistoryItemAsContentStatus
{
    /// <include file='SetHistoryItemAsContentStatus.xml' path='doc/member[@name="SetHistoryItemAsContentStatus.SetHistoryItemAsContentStatus_Success"]/*' />
    SetHistoryItemAsContentStatus_Success = 0,

    /// <include file='SetHistoryItemAsContentStatus.xml' path='doc/member[@name="SetHistoryItemAsContentStatus.SetHistoryItemAsContentStatus_AccessDenied"]/*' />
    SetHistoryItemAsContentStatus_AccessDenied = 1,

    /// <include file='SetHistoryItemAsContentStatus.xml' path='doc/member[@name="SetHistoryItemAsContentStatus.SetHistoryItemAsContentStatus_ItemDeleted"]/*' />
    SetHistoryItemAsContentStatus_ItemDeleted = 2,
}
