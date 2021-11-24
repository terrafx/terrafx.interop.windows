// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public unsafe partial struct STORAGE_OFFLOAD_TOKEN
{
    [NativeTypeName("BYTE [4]")]
    public fixed byte TokenType[4];

    [NativeTypeName("BYTE [2]")]
    public fixed byte Reserved[2];

    [NativeTypeName("BYTE [2]")]
    public fixed byte TokenIdLength[2];

    [NativeTypeName("_STORAGE_OFFLOAD_TOKEN::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:3426:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref _Anonymous_e__Union._StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.StorageOffloadZeroDataToken, 1));
        }
    }

    public Span<byte> Token
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Token[0], 504);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:3427:9)")]
        public _StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken;

        [FieldOffset(0)]
        [NativeTypeName("BYTE [504]")]
        public fixed byte Token[504];

        public unsafe partial struct _StorageOffloadZeroDataToken_e__Struct
        {
            [NativeTypeName("BYTE [504]")]
            public fixed byte Reserved2[504];
        }
    }
}
