// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct MARK_HANDLE_INFO
    {
        [NativeTypeName("_MARK_HANDLE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:11696:5)")]
        public _Anonymous_e__Union Anonymous;

        public HANDLE VolumeHandle;

        [NativeTypeName("DWORD")]
        public uint HandleInfo;

        public ref uint UsnSourceInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UsnSourceInfo, 1));
            }
        }

        public ref uint CopyNumber
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CopyNumber, 1));
            }
        }

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
