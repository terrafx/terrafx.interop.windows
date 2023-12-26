// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FolderDepth.xml' path='doc/member[@name="FolderDepth"]/*' />
public enum FolderDepth
{
    /// <include file='FolderDepth.xml' path='doc/member[@name="FolderDepth.FolderDepth_Shallow"]/*' />
    FolderDepth_Shallow = 0,

    /// <include file='FolderDepth.xml' path='doc/member[@name="FolderDepth.FolderDepth_Deep"]/*' />
    FolderDepth_Deep = 1,
}
