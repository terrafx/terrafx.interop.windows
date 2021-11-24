// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct TRANSACTION_NOTIFICATION
{
    [NativeTypeName("PVOID")]
    public void* TransactionKey;

    [NativeTypeName("ULONG")]
    public uint TransactionNotification;

    public LARGE_INTEGER TmVirtualClock;

    [NativeTypeName("ULONG")]
    public uint ArgumentLength;
}
