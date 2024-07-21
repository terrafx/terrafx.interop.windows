// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PickerViewMode.xml' path='doc/member[@name="PickerViewMode"]/*' />
public enum PickerViewMode
{
    /// <include file='PickerViewMode.xml' path='doc/member[@name="PickerViewMode.PickerViewMode_List"]/*' />
    PickerViewMode_List = 0,

    /// <include file='PickerViewMode.xml' path='doc/member[@name="PickerViewMode.PickerViewMode_Thumbnail"]/*' />
    PickerViewMode_Thumbnail = 1,
}
