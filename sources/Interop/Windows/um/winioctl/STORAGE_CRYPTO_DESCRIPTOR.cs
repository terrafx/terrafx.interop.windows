// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_CRYPTO_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NumKeysSupported;

        [NativeTypeName("DWORD")]
        public uint NumCryptoCapabilities;

        [NativeTypeName("STORAGE_CRYPTO_CAPABILITY [1]")]
        public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;

        public partial struct _CryptoCapabilities_e__FixedBuffer
        {
            public STORAGE_CRYPTO_CAPABILITY e0;

            public unsafe ref STORAGE_CRYPTO_CAPABILITY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<STORAGE_CRYPTO_CAPABILITY> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<STORAGE_CRYPTO_CAPABILITY>((STORAGE_CRYPTO_CAPABILITY*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
