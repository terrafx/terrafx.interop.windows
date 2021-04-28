// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IDedupReadFileCallback = new Guid(0x7BACC67A, 0x2F1D, 0x42D0, 0x89, 0x7E, 0x6F, 0xF6, 0x2D, 0xD5, 0x33, 0xBB);

        public static readonly Guid IID_IDedupBackupSupport = new Guid(0xC719D963, 0x2B2D, 0x415E, 0xAC, 0xF7, 0x7E, 0xB7, 0xCA, 0x59, 0x6F, 0xF4);

        public static readonly Guid CLSID_DedupBackupSupport = new Guid(0x73D6B2AD, 0x2984, 0x4715, 0xB2, 0xE3, 0x92, 0x4C, 0x14, 0x97, 0x44, 0xDD);
    }
}
