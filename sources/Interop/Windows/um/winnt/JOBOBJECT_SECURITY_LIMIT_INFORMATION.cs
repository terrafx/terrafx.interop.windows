// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint SecurityLimitFlags;

        [NativeTypeName("HANDLE")]
        public IntPtr JobToken;

        [NativeTypeName("PTOKEN_GROUPS")]
        public TOKEN_GROUPS* SidsToDisable;

        [NativeTypeName("PTOKEN_PRIVILEGES")]
        public TOKEN_PRIVILEGES* PrivilegesToDelete;

        [NativeTypeName("PTOKEN_GROUPS")]
        public TOKEN_GROUPS* RestrictedSids;
    }
}
