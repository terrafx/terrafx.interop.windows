// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct tagFolderSetData
    {
        public FOLDERSETTINGS _fs;

        [NativeTypeName("SHELLVIEWID")]
        public Guid _vidRestore;

        [NativeTypeName("DWORD")]
        public uint _dwViewPriority;
    }
}
