// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SYSTEM_CPU_SET_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        public CPU_SET_INFORMATION_TYPE Type;

        [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12628:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._CpuSet_e__Struct CpuSet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CpuSet, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12629:9)")]
            public _CpuSet_e__Struct CpuSet;

            public partial struct _CpuSet_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Id;

                [NativeTypeName("WORD")]
                public ushort Group;

                [NativeTypeName("BYTE")]
                public byte LogicalProcessorIndex;

                [NativeTypeName("BYTE")]
                public byte CoreIndex;

                [NativeTypeName("BYTE")]
                public byte LastLevelCacheIndex;

                [NativeTypeName("BYTE")]
                public byte NumaNodeIndex;

                [NativeTypeName("BYTE")]
                public byte EfficiencyClass;

                [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12637:13)")]
                public _Anonymous1_e__Union Anonymous1;

                public ref byte AllFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.AllFlags, 1));
                    }
                }

                public byte Parked
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.Parked;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.Parked = value;
                    }
                }

                public byte Allocated
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.Allocated;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.Allocated = value;
                    }
                }

                public byte AllocatedToTargetProcess
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.AllocatedToTargetProcess;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.AllocatedToTargetProcess = value;
                    }
                }

                public byte RealTime
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.RealTime;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.RealTime = value;
                    }
                }

                public byte ReservedFlags
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return Anonymous1.Anonymous.ReservedFlags;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        Anonymous1.Anonymous.ReservedFlags = value;
                    }
                }

                [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12654:13)")]
                public _Anonymous2_e__Union Anonymous2;

                public ref uint Reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Reserved, 1));
                    }
                }

                public ref byte SchedulingClass
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.SchedulingClass, 1));
                    }
                }

                [NativeTypeName("DWORD64")]
                public ulong AllocationTag;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous1_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("BYTE")]
                    public byte AllFlags;

                    [FieldOffset(0)]
                    [NativeTypeName("_SYSTEM_CPU_SET_INFORMATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12645:17)")]
                    public _Anonymous_e__Struct Anonymous;

                    public partial struct _Anonymous_e__Struct
                    {
                        public byte _bitfield;

                        [NativeTypeName("BYTE : 1")]
                        public byte Parked
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)(_bitfield & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                            }
                        }

                        [NativeTypeName("BYTE : 1")]
                        public byte Allocated
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 1) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                            }
                        }

                        [NativeTypeName("BYTE : 1")]
                        public byte AllocatedToTargetProcess
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 2) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
                            }
                        }

                        [NativeTypeName("BYTE : 1")]
                        public byte RealTime
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 3) & 0x1u);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
                            }
                        }

                        [NativeTypeName("BYTE : 4")]
                        public byte ReservedFlags
                        {
                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            get
                            {
                                return (byte)((_bitfield >> 4) & 0xFu);
                            }

                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                            set
                            {
                                _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                            }
                        }
                    }
                }

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous2_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("DWORD")]
                    public uint Reserved;

                    [FieldOffset(0)]
                    [NativeTypeName("BYTE")]
                    public byte SchedulingClass;
                }
            }
        }
    }
}
