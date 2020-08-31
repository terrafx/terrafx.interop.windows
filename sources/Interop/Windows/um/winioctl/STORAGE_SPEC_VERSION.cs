// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct STORAGE_SPEC_VERSION
    {
        [FieldOffset(0)]
        [NativeTypeName("_STORAGE_SPEC_VERSION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2461:5)")]
        public _Anonymous_e__Struct Anonymous;

        public ref _Anonymous_e__Struct._MinorVersion_e__Union MinorVersion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MinorVersion, 1));
            }
        }

        public ref ushort MajorVersion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MajorVersion, 1));
            }
        }

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AsUlong;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2462:9)")]
            public _MinorVersion_e__Union MinorVersion;

            [NativeTypeName("WORD")]
            public ushort MajorVersion;

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _MinorVersion_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("_STORAGE_SPEC_VERSION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:2463:13)")]
                public _Anonymous_e__Struct Anonymous;

                public ref byte SubMinor
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SubMinor, 1));
                    }
                }

                public ref byte Minor
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Minor, 1));
                    }
                }

                [FieldOffset(0)]
                [NativeTypeName("WORD")]
                public ushort AsUshort;

                public partial struct _Anonymous_e__Struct
                {
                    [NativeTypeName("BYTE")]
                    public byte SubMinor;

                    [NativeTypeName("BYTE")]
                    public byte Minor;
                }
            }
        }
    }
}
