// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xB3, 0x0C, 0x73,
                    0xDC, 0x51,
                    0xDA, 0x49,
                    0xA5,
                    0x78,
                    0xB9,
                    0x53,
                    0x86,
                    0xB6,
                    0x2A,
                    0xFE,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_STOREPATH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x93, 0xD9, 0x77,
                    0x61, 0xBA,
                    0xB7, 0x4B,
                    0x92,
                    0xC6,
                    0x18,
                    0xC8,
                    0x6A,
                    0x18,
                    0x9C,
                    0x06,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x28, 0x2A, 0x6D,
                    0xA9, 0xC3,
                    0x81, 0x46,
                    0x97,
                    0xF2,
                    0x0A,
                    0xF5,
                    0x6B,
                    0xE9,
                    0x34,
                    0x46,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_CONTENTDECRYPTIONMODULE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x0C, 0x32, 0x15,
                    0x80, 0xFF,
                    0x4A, 0x48,
                    0x9D,
                    0xCB,
                    0x0D,
                    0xF8,
                    0x94,
                    0xE6,
                    0x9A,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [SupportedOSPlatform("windows10.0.19041.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateEncryptedMediaExtensionsStoreActivate(IMFPMPHostApp* pmpHost, IStream* objectStream, [NativeTypeName("LPCWSTR")] ushort* classId, IMFActivate** activate);

        public static ref readonly Guid IID_IMFContentDecryptionModuleSession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x3E, 0x23, 0x4E,
                    0xD2, 0x1D,
                    0xE8, 0x49,
                    0xB5,
                    0x77,
                    0xD6,
                    0x3E,
                    0xEE,
                    0x4C,
                    0x0D,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentDecryptionModuleSessionCallbacks
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xEE, 0x96, 0x3F,
                    0x81, 0xAD,
                    0x96, 0x40,
                    0x84,
                    0x70,
                    0x59,
                    0xA4,
                    0xB7,
                    0x70,
                    0xF8,
                    0x9A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentDecryptionModule
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0x98, 0xBE, 0x87,
                    0xBE, 0x10,
                    0x43, 0x49,
                    0xBF,
                    0x48,
                    0x4B,
                    0x54,
                    0xCE,
                    0x19,
                    0x83,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentDecryptionModuleAccess
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0xD1, 0x53, 0xA8,
                    0xA0, 0xE2,
                    0x03, 0x43,
                    0x9E,
                    0xDC,
                    0xF1,
                    0xA6,
                    0x8E,
                    0xE4,
                    0x31,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentDecryptionModuleFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0xBF, 0x5A, 0x7D,
                    0xBB, 0x4C,
                    0x08, 0x4E,
                    0xB9,
                    0x77,
                    0x9B,
                    0xA5,
                    0x90,
                    0x49,
                    0x94,
                    0x3E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
