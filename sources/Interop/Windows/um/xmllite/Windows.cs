// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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
        public static readonly Guid IID_IXmlReader = new Guid(0x7279FC81, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IXmlWriter = new Guid(0x7279FC88, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IXmlResolver = new Guid(0x7279FC82, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30);

        public static readonly Guid IID_IXmlWriterLite = new Guid(0x862494C6, 0x1310, 0x4AAD, 0xB3, 0xCD, 0x2D, 0xBE, 0xEB, 0xF6, 0x70, 0xD3);
    }
}
