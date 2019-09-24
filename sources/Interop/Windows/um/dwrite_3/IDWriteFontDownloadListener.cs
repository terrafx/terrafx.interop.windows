// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Application-defined callback interface that receives notifications from the font download queue (IDWriteFontDownloadQueue interface). Callbacks will occur on the downloading thread, and objects must be prepared to handle calls on their methods from other threads at any time.</summary>
    [Guid("B06FE5B9-43EC-4393-881B-DBE4DC72FDA7")]
    public unsafe struct IDWriteFontDownloadListener
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontDownloadListener* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontDownloadListener* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontDownloadListener* This
        );

        /// <summary>The DownloadCompleted method is called back on an arbitrary thread when a download operation ends.</summary>
        /// <param name="downloadQueue">Pointer to the download queue interface on which the BeginDownload method was called.</param>
        /// <param name="context">Optional context object that was passed to BeginDownload. AddRef is called on the context object by BeginDownload and Release is called after the DownloadCompleted method returns.</param>
        /// <param name="downloadResult">Result of the download operation.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _DownloadCompleted(
            [In] IDWriteFontDownloadListener* This,
            [In] IDWriteFontDownloadQueue* downloadQueue,
            [In, Optional] IUnknown* context,
            [In, NativeTypeName("HRESULT")] int downloadResult
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
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
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void DownloadCompleted(
            [In] IDWriteFontDownloadQueue* downloadQueue,
            [In, Optional] IUnknown* context,
            [In, NativeTypeName("HRESULT")] int downloadResult
        )
        {
            fixed (IDWriteFontDownloadListener* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DownloadCompleted>(lpVtbl->DownloadCompleted)(
                    This,
                    downloadQueue,
                    context,
                    downloadResult
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr DownloadCompleted;
        }
    }
}
