// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct WINHTTP_REQUEST_TIMES32
{
    [NativeTypeName("ULONG")]
    public uint cTimes;

    [NativeTypeName("ULONGLONG[64]")]
    public _rgullTimes_e__FixedBuffer rgullTimes;

    [InlineArray(64)]
    public partial struct _rgullTimes_e__FixedBuffer
    {
        public ulong e0;
    }
}
