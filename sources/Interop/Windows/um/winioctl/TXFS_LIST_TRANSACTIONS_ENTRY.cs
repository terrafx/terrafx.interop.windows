// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TXFS_LIST_TRANSACTIONS_ENTRY
    {
        [NativeTypeName("GUID")]
        public Guid TransactionId;

        [NativeTypeName("DWORD")]
        public uint TransactionState;

        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("LONGLONG")]
        public long Reserved3;
    }
}
