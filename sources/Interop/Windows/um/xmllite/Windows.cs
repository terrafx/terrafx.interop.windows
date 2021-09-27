// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlReader([NativeTypeName("const IID &")] Guid* riid, void** ppvObject, IMalloc* pMalloc);

        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlReaderInputWithEncodingCodePage(IUnknown* pInputStream, IMalloc* pMalloc, [NativeTypeName("UINT")] uint nEncodingCodePage, [NativeTypeName("BOOL")] int fEncodingHint, [NativeTypeName("LPCWSTR")] ushort* pwszBaseUri, [NativeTypeName("IXmlReaderInput **")] IUnknown** ppInput);

        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlReaderInputWithEncodingName(IUnknown* pInputStream, IMalloc* pMalloc, [NativeTypeName("LPCWSTR")] ushort* pwszEncodingName, [NativeTypeName("BOOL")] int fEncodingHint, [NativeTypeName("LPCWSTR")] ushort* pwszBaseUri, [NativeTypeName("IXmlReaderInput **")] IUnknown** ppInput);

        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlWriter([NativeTypeName("const IID &")] Guid* riid, void** ppvObject, IMalloc* pMalloc);

        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlWriterOutputWithEncodingCodePage(IUnknown* pOutputStream, IMalloc* pMalloc, [NativeTypeName("UINT")] uint nEncodingCodePage, [NativeTypeName("IXmlWriterOutput **")] IUnknown** ppOutput);

        [DllImport("xmllite", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateXmlWriterOutputWithEncodingName(IUnknown* pOutputStream, IMalloc* pMalloc, [NativeTypeName("LPCWSTR")] ushort* pwszEncodingName, [NativeTypeName("IXmlWriterOutput **")] IUnknown** ppOutput);

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IXmlReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xFC, 0x79, 0x72,
                    0x9D, 0x70,
                    0x95, 0x40,
                    0xB6,
                    0x3D,
                    0x69,
                    0xFE,
                    0x4B,
                    0x0D,
                    0x90,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IXmlWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0xFC, 0x79, 0x72,
                    0x9D, 0x70,
                    0x95, 0x40,
                    0xB6,
                    0x3D,
                    0x69,
                    0xFE,
                    0x4B,
                    0x0D,
                    0x90,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IXmlResolver
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xFC, 0x79, 0x72,
                    0x9D, 0x70,
                    0x95, 0x40,
                    0xB6,
                    0x3D,
                    0x69,
                    0xFE,
                    0x4B,
                    0x0D,
                    0x90,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXmlWriterLite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0x94, 0x24, 0x86,
                    0x10, 0x13,
                    0xAD, 0x4A,
                    0xB3,
                    0xCD,
                    0x2D,
                    0xBE,
                    0xEB,
                    0xF6,
                    0x70,
                    0xD3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
