// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSPEC
    {
        [NativeTypeName("ULONG")]
        public uint ulKind;

        [NativeTypeName("tagPROPSPEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/PropIdlBase.h:444:43)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint propid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.propid, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->propid;
#endif
            }
        }

        public unsafe ref ushort* lpwstr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->lpwstr;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PROPID")]
            public uint propid;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public ushort* lpwstr;
        }
    }
}
