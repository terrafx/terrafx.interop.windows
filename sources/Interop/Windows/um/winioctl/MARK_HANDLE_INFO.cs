// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MARK_HANDLE_INFO
    {
        [NativeTypeName("MARK_HANDLE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11047:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint UsnSourceInfo => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UsnSourceInfo, 1));

        public ref uint CopyNumber => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CopyNumber, 1));

        [NativeTypeName("HANDLE")]
        public IntPtr VolumeHandle;

        [NativeTypeName("DWORD")]
        public uint HandleInfo;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint UsnSourceInfo;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint CopyNumber;
        }
    }
}
