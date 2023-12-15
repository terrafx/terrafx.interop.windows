// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_BACKUP_QUEUE_PARAMS32_V2_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("WCHAR[260]")]
    public _FullInfPath_e__FixedBuffer FullInfPath;

    public int FilenameOffset;

    [NativeTypeName("WCHAR[260]")]
    public _ReinstallInstance_e__FixedBuffer ReinstallInstance;

    [InlineArray(260)]
    public partial struct _FullInfPath_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _ReinstallInstance_e__FixedBuffer
    {
        public char e0;
    }
}
