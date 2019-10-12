// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteRemoteFontFileLoader interface represents a font file loader that can access remote (i.e., downloadable) fonts. The IDWriteFactory5::CreateHttpFontFileLoader method returns an instance of this interface, or a client can create its own implementation.</summary>
    /// <remarks> Calls to a remote file loader or stream should never block waiting for network operations. Any call that cannot succeeded immediately using local (e.g., cached) must should return DWRITE_E_REMOTEFONT. This error signifies to DWrite that it should add requests to the font download queue.</remarks>
    [Guid("68648C83-6EDE-46C0-AB46-20083A887FDE")]
    public unsafe partial struct IDWriteRemoteFontFileLoader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRemoteFontFileLoader* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRemoteFontFileLoader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRemoteFontFileLoader* This);

        /// <summary>Creates a font file stream object that encapsulates an open file resource. The resource is closed when the last reference to fontFileStream is released.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStreamFromKey(IDWriteRemoteFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream);

        /// <summary>Creates a remote font file stream object that encapsulates an open file resource and can be used to download remote file data.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Unlike CreateStreamFromKey, this method can be used to create a stream for a remote file. If the file is remote, the client must call IDWriteRemoteFontFileStream::DownloadFileInformation before the stream can be used to get the file size or access data.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRemoteStreamFromKey(IDWriteRemoteFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream);

        /// <summary>Gets the locality of the file resource identified by the unique key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="locality">Locality of the file.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocalityFromKey(IDWriteRemoteFontFileLoader* This, void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, DWRITE_LOCALITY* locality);

        /// <summary>Creates a font file reference from a URL if the loader supports this capability.</summary>
        /// <param name="factory">Factory used to create the font file reference.</param>
        /// <param name="baseUrl">Optional base URL. The base URL is used to resolve the fontFileUrl if it is relative. For example, the baseUrl might be the URL of the referring document that contained the fontFileUrl.</param>
        /// <param name="fontFileUrl">URL of the font resource.</param>
        /// <param name="fontFile">Receives a pointer to the newly created font file reference.</param>
        /// <returns> Standard HRESULT error code, or E_NOTIMPL if the loader does not implement this method.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFileReferenceFromUrl(IDWriteRemoteFontFileLoader* This, IDWriteFactory* factory, [Optional, NativeTypeName("WCHAR[]")] ushort* baseUrl, [NativeTypeName("WCHAR[]")] ushort* fontFileUrl, IDWriteFontFile** fontFile);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRemoteStreamFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRemoteStreamFromKey>(lpVtbl->CreateRemoteStreamFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalityFromKey(void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, DWRITE_LOCALITY* locality)
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocalityFromKey>(lpVtbl->GetLocalityFromKey)(This, fontFileReferenceKey, fontFileReferenceKeySize, locality);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReferenceFromUrl(IDWriteFactory* factory, [Optional, NativeTypeName("WCHAR[]")] ushort* baseUrl, [NativeTypeName("WCHAR[]")] ushort* fontFileUrl, IDWriteFontFile** fontFile)
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFileReferenceFromUrl>(lpVtbl->CreateFontFileReferenceFromUrl)(This, factory, baseUrl, fontFileUrl, fontFile);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateStreamFromKey;

            public IntPtr CreateRemoteStreamFromKey;

            public IntPtr GetLocalityFromKey;

            public IntPtr CreateFontFileReferenceFromUrl;
        }
    }
}
