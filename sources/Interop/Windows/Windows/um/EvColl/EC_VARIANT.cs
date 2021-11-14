// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct EC_VARIANT
    {
        [NativeTypeName("_EC_VARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/EvColl.h:121:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint Count;

        [NativeTypeName("DWORD")]
        public uint Type;

        public ref BOOL BooleanVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.BooleanVal, 1));
            }
        }

        public ref uint UInt32Val
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UInt32Val, 1));
            }
        }

        public ref ulong DateTimeVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DateTimeVal, 1));
            }
        }

        public ref ushort* StringVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.StringVal;
            }
        }

        public ref byte* BinaryVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.BinaryVal;
            }
        }

        public ref BOOL* BooleanArr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.BooleanArr;
            }
        }

        public ref int* Int32Arr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Int32Arr;
            }
        }

        public ref ushort** StringArr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.StringArr;
            }
        }

        public ref EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.PropertyHandleVal;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public BOOL BooleanVal;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint UInt32Val;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong DateTimeVal;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* StringVal;

            [FieldOffset(0)]
            [NativeTypeName("PBYTE")]
            public byte* BinaryVal;

            [FieldOffset(0)]
            public BOOL* BooleanArr;

            [FieldOffset(0)]
            [NativeTypeName("INT32 *")]
            public int* Int32Arr;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR *")]
            public ushort** StringArr;

            [FieldOffset(0)]
            public EC_OBJECT_ARRAY_PROPERTY_HANDLE PropertyHandleVal;
        }
    }
}
