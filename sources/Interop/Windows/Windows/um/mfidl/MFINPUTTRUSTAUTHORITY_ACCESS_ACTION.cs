// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MFINPUTTRUSTAUTHORITY_ACCESS_ACTION
{
    public MFPOLICYMANAGER_ACTION Action;

    public byte* pbTicket;

    [NativeTypeName("DWORD")]
    public uint cbTicket;
}
