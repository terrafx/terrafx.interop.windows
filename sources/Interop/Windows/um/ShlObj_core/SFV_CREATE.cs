// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SFV_CREATE
    {
        public uint cbSize;

        public IShellFolder* pshf;

        public IShellView* psvOuter;

        public IShellFolderViewCB* psfvcb;
    }
}
