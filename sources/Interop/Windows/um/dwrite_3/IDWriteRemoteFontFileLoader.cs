// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteRemoteFontFileLoader interface represents a font file loader that can access remote (i.e., downloadable) fonts. The IDWriteFactory5::CreateHttpFontFileLoader method returns an instance of this interface, or a client can create its own implementation.</summary>
    /// <remarks> Calls to a remote file loader or stream should never block waiting for network operations. Any call that cannot succeeded immediately using local (e.g., cached) must should return DWRITE_E_REMOTEFONT. This error signifies to DWrite that it should add requests to the font download queue.</remarks>
    [Guid("68648C83-6EDE-46C0-AB46-20083A887FDE")]
    [Unmanaged]
    public unsafe struct IDWriteRemoteFontFileLoader
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteRemoteFontFileLoader* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteRemoteFontFileLoader* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteRemoteFontFileLoader* This
        );
        #endregion

        #region IDWriteFontFileLoader Delegates
        /// <summary>Creates a font file stream object that encapsulates an open file resource. The resource is closed when the last reference to fontFileStream is released.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStreamFromKey(
            [In] IDWriteRemoteFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        );
        #endregion

        #region Delegates
        /// <summary>Creates a remote font file stream object that encapsulates an open file resource and can be used to download remote file data.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="fontFileStream">Pointer to the newly created font file stream.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> Unlike CreateStreamFromKey, this method can be used to create a stream for a remote file. If the file is remote, the client must call IDWriteRemoteFontFileStream::DownloadFileInformation before the stream can be used to get the file size or access data.</remarks>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateRemoteStreamFromKey(
            [In] IDWriteRemoteFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteRemoteFontFileStream** fontFileStream
        );

        /// <summary>Gets the locality of the file resource identified by the unique key.</summary>
        /// <param name="fontFileReferenceKey">Font file reference key that uniquely identifies the font file resource within the scope of the font loader being used.</param>
        /// <param name="fontFileReferenceKeySize">Size of font file reference key in bytes.</param>
        /// <param name="locality">Locality of the file.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocalityFromKey(
            [In] IDWriteRemoteFontFileLoader* This,
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] DWRITE_LOCALITY* locality
        );

        /// <summary>Creates a font file reference from a URL if the loader supports this capability.</summary>
        /// <param name="factory">Factory used to create the font file reference.</param>
        /// <param name="baseUrl">Optional base URL. The base URL is used to resolve the fontFileUrl if it is relative. For example, the baseUrl might be the URL of the referring document that contained the fontFileUrl.</param>
        /// <param name="fontFileUrl">URL of the font resource.</param>
        /// <param name="fontFile">Receives a pointer to the newly created font file reference.</param>
        /// <returns> Standard HRESULT error code, or E_NOTIMPL if the loader does not implement this method.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontFileReferenceFromUrl(
            [In] IDWriteRemoteFontFileLoader* This,
            [In] IDWriteFactory* factory,
            [In, Optional, NativeTypeName("WCHAR[]")] char* baseUrl,
            [In, NativeTypeName("WCHAR[]")] char* fontFileUrl,
            [Out] IDWriteFontFile** fontFile
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteFontFileLoader Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteFontFileStream** fontFileStream
        )
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_CreateStreamFromKey>(lpVtbl->CreateStreamFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    fontFileStream
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateRemoteStreamFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] IDWriteRemoteFontFileStream** fontFileStream
        )
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_CreateRemoteStreamFromKey>(lpVtbl->CreateRemoteStreamFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    fontFileStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalityFromKey(
            [In] void* fontFileReferenceKey,
            [In, NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [Out] DWRITE_LOCALITY* locality
        )
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_GetLocalityFromKey>(lpVtbl->GetLocalityFromKey)(
                    This,
                    fontFileReferenceKey,
                    fontFileReferenceKeySize,
                    locality
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReferenceFromUrl(
            [In] IDWriteFactory* factory,
            [In, Optional, NativeTypeName("WCHAR[]")] char* baseUrl,
            [In, NativeTypeName("WCHAR[]")] char* fontFileUrl,
            [Out] IDWriteFontFile** fontFile
        )
        {
            fixed (IDWriteRemoteFontFileLoader* This = &this)
            {
                return MarshalFunction<_CreateFontFileReferenceFromUrl>(lpVtbl->CreateFontFileReferenceFromUrl)(
                    This,
                    factory,
                    baseUrl,
                    fontFileUrl,
                    fontFile
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDWriteFontFileLoader Fields
            public IntPtr CreateStreamFromKey;
            #endregion

            #region Fields
            public IntPtr CreateRemoteStreamFromKey;

            public IntPtr GetLocalityFromKey;

            public IntPtr CreateFontFileReferenceFromUrl;
            #endregion
        }
        #endregion
    }
}
