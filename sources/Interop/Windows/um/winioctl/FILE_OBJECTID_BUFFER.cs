// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct FILE_OBJECTID_BUFFER
    {
        [NativeTypeName("BYTE [16]")]
        public fixed byte ObjectId[16];

        [NativeTypeName("_FILE_OBJECTID_BUFFER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11649:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe Span<byte> BirthVolumeId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.BirthVolumeId[0], 16);
#else
                return new Span<byte>(((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->BirthVolumeId, 16);
#endif
            }
        }

        public unsafe Span<byte> BirthObjectId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.BirthObjectId[0], 16);
#else
                return new Span<byte>(((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->BirthObjectId, 16);
#endif
            }
        }

        public unsafe Span<byte> DomainId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.DomainId[0], 16);
#else
                return new Span<byte>(((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->DomainId, 16);
#endif
            }
        }

        public unsafe Span<byte> ExtendedInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.ExtendedInfo[0], 48);
#else
                return new Span<byte>(((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->ExtendedInfo, 48);
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_FILE_OBJECTID_BUFFER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:11650:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("BYTE [48]")]
            public fixed byte ExtendedInfo[48];

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("BYTE [16]")]
                public fixed byte BirthVolumeId[16];

                [NativeTypeName("BYTE [16]")]
                public fixed byte BirthObjectId[16];

                [NativeTypeName("BYTE [16]")]
                public fixed byte DomainId[16];
            }
        }
    }
}
