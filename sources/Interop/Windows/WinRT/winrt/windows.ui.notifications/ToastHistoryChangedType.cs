// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ToastHistoryChangedType.xml' path='doc/member[@name="ToastHistoryChangedType"]/*' />
public enum ToastHistoryChangedType
{
    /// <include file='ToastHistoryChangedType.xml' path='doc/member[@name="ToastHistoryChangedType.ToastHistoryChangedType_Cleared"]/*' />
    ToastHistoryChangedType_Cleared = 0,

    /// <include file='ToastHistoryChangedType.xml' path='doc/member[@name="ToastHistoryChangedType.ToastHistoryChangedType_Removed"]/*' />
    ToastHistoryChangedType_Removed = 1,

    /// <include file='ToastHistoryChangedType.xml' path='doc/member[@name="ToastHistoryChangedType.ToastHistoryChangedType_Expired"]/*' />
    ToastHistoryChangedType_Expired = 2,

    /// <include file='ToastHistoryChangedType.xml' path='doc/member[@name="ToastHistoryChangedType.ToastHistoryChangedType_Added"]/*' />
    ToastHistoryChangedType_Added = 3,
}
