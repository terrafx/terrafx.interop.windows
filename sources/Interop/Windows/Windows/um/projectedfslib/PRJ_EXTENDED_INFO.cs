// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct PRJ_EXTENDED_INFO
{
    public PRJ_EXT_INFO_TYPE InfoType;

    [NativeTypeName("ULONG")]
    public uint NextInfoOffset;

    [NativeTypeName("PRJ_EXTENDED_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:102:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref _Anonymous_e__Union._Symlink_e__Struct Symlink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Symlink, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/projectedfslib.h:103:9)")]
        public _Symlink_e__Struct Symlink;

        public unsafe partial struct _Symlink_e__Struct
        {
            [NativeTypeName("PCWSTR")]
            public ushort* TargetName;
        }
    }
}
