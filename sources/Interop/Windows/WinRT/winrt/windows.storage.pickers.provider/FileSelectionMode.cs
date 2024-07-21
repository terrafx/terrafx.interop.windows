// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FileSelectionMode.xml' path='doc/member[@name="FileSelectionMode"]/*' />
public enum FileSelectionMode
{
    /// <include file='FileSelectionMode.xml' path='doc/member[@name="FileSelectionMode.FileSelectionMode_Single"]/*' />
    FileSelectionMode_Single = 0,

    /// <include file='FileSelectionMode.xml' path='doc/member[@name="FileSelectionMode.FileSelectionMode_Multiple"]/*' />
    FileSelectionMode_Multiple = 1,
}
