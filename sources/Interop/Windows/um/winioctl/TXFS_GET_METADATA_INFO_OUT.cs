// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TXFS_GET_METADATA_INFO_OUT
    {
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:13368:5)")]
        public _TxfFileId_e__Struct TxfFileId;

        public Guid LockingTransaction;

        [NativeTypeName("DWORDLONG")]
        public ulong LastLsn;

        [NativeTypeName("DWORD")]
        public uint TransactionState;

        public partial struct _TxfFileId_e__Struct
        {
            [NativeTypeName("LONGLONG")]
            public long LowPart;

            [NativeTypeName("LONGLONG")]
            public long HighPart;
        }
    }
}
