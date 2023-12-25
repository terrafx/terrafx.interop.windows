// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ColorManagementMode.xml' path='doc/member[@name="ColorManagementMode"]/*' />
public enum ColorManagementMode
{
    /// <include file='ColorManagementMode.xml' path='doc/member[@name="ColorManagementMode.ColorManagementMode_DoNotColorManage"]/*' />
    ColorManagementMode_DoNotColorManage = 0,

    /// <include file='ColorManagementMode.xml' path='doc/member[@name="ColorManagementMode.ColorManagementMode_ColorManageToSRgb"]/*' />
    ColorManagementMode_ColorManageToSRgb = 1,
}
