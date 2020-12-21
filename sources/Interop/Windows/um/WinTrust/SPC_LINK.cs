// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SPC_LINK
    {
        [NativeTypeName("DWORD")]
        public uint dwLinkChoice;

        [NativeTypeName("SPC_LINK_::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinTrust.h:1280:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref ushort* pwszUrl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pwszUrl;
            }
        }

        public unsafe ref SPC_SERIALIZED_OBJECT Moniker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Moniker, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Moniker;
#endif
            }
        }

        public unsafe ref ushort* pwszFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pwszFile;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszUrl;

            [FieldOffset(0)]
            public SPC_SERIALIZED_OBJECT Moniker;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszFile;
        }
    }
}
