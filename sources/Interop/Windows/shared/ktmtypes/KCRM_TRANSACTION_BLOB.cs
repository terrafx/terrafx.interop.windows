// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct KCRM_TRANSACTION_BLOB
    {
        [NativeTypeName("UOW")]
        public Guid UOW;

        [NativeTypeName("GUID")]
        public Guid TmIdentity;

        [NativeTypeName("ULONG")]
        public uint IsolationLevel;

        [NativeTypeName("ULONG")]
        public uint IsolationFlags;

        [NativeTypeName("ULONG")]
        public uint Timeout;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort Description[64];
    }
}
