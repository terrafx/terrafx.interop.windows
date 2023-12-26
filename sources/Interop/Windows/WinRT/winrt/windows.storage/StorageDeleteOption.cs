// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StorageDeleteOption.xml' path='doc/member[@name="StorageDeleteOption"]/*' />
public enum StorageDeleteOption
{
    /// <include file='StorageDeleteOption.xml' path='doc/member[@name="StorageDeleteOption.StorageDeleteOption_Default"]/*' />
    StorageDeleteOption_Default = 0,

    /// <include file='StorageDeleteOption.xml' path='doc/member[@name="StorageDeleteOption.StorageDeleteOption_PermanentDelete"]/*' />
    StorageDeleteOption_PermanentDelete = 1,
}
