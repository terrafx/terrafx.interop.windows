// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Application-defined callback interface that receives notifications from the font download queue (IDWriteFontDownloadQueue interface). Callbacks will occur on the downloading thread, and objects must be prepared to handle calls on their methods from other threads at any time.</summary>
    [Guid("B06FE5B9-43EC-4393-881B-DBE4DC72FDA7")]
    public unsafe struct IDWriteFontDownloadListener
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontDownloadListener* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontDownloadListener* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontDownloadListener* This
        );
        #endregion

        #region Delegates
        /// <summary>The DownloadCompleted method is called back on an arbitrary thread when a download operation ends.</summary>
        /// <param name="downloadQueue">Pointer to the download queue interface on which the BeginDownload method was called.</param>
        /// <param name="context">Optional context object that was passed to BeginDownload. AddRef is called on the context object by BeginDownload and Release is called after the DownloadCompleted method returns.</param>
        /// <param name="downloadResult">Result of the download operation.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DownloadCompleted(
            [In] IDWriteFontDownloadListener* This,
            [In] IDWriteFontDownloadQueue* downloadQueue,
            [In, Optional] IUnknown* context,
            [In, NativeTypeName("HRESULT")] int downloadResult
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontDownloadListener* This = &this)
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
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        public void DownloadCompleted(
            [In] IDWriteFontDownloadQueue* downloadQueue,
            [In, Optional] IUnknown* context,
            [In, NativeTypeName("HRESULT")] int downloadResult
        )
        {
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                MarshalFunction<_DownloadCompleted>(lpVtbl->DownloadCompleted)(
                    This,
                    downloadQueue,
                    context,
                    downloadResult
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr DownloadCompleted;
            #endregion
        }
        #endregion
    }
}
