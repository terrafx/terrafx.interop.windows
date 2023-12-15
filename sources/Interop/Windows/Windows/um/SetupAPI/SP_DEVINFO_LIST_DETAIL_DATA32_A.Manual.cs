// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_DEVINFO_LIST_DETAIL_DATA32_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public Guid ClassGuid;

    public HANDLE RemoteMachineHandle;

    [NativeTypeName("CHAR[263]")]
    public _RemoteMachineName_e__FixedBuffer RemoteMachineName;

    [InlineArray(263)]
    public partial struct _RemoteMachineName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
