// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICBitmapEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICBitmapEncoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICBitmapEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICBitmapEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(
            [In] IWICBitmapEncoder* This,
            [In, Optional] IStream* pIStream,
            [In] WICBitmapEncoderCacheOption cacheOption
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(
            [In] IWICBitmapEncoder* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncoderInfo(
            [In] IWICBitmapEncoder* This,
            [Out] IWICBitmapEncoderInfo** ppIEncoderInfo = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorContexts(
            [In] IWICBitmapEncoder* This,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(
            [In] IWICBitmapEncoder* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetThumbnail(
            [In] IWICBitmapEncoder* This,
            [In] IWICBitmapSource* pIThumbnail = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPreview(
            [In] IWICBitmapEncoder* This,
            [In] IWICBitmapSource* pIPreview = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNewFrame(
            [In] IWICBitmapEncoder* This,
            [Out] IWICBitmapFrameEncode** ppIFrameEncode = null,
            [In, Out] IPropertyBag2** ppIEncoderOptions = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(
            [In] IWICBitmapEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryWriter(
            [In] IWICBitmapEncoder* This,
            [Out] IWICMetadataQueryWriter** ppIMetadataQueryWriter = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
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
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(
            [In, Optional] IStream* pIStream,
            [In] WICBitmapEncoderCacheOption cacheOption
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(
                    This,
                    pIStream,
                    cacheOption
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
                    This,
                    pguidContainerFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoderInfo(
            [Out] IWICBitmapEncoderInfo** ppIEncoderInfo = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEncoderInfo>(lpVtbl->GetEncoderInfo)(
                    This,
                    ppIEncoderInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts(
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorContexts>(lpVtbl->SetColorContexts)(
                    This,
                    cCount,
                    ppIColorContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(
            [In] IWICBitmapSource* pIThumbnail = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetThumbnail>(lpVtbl->SetThumbnail)(
                    This,
                    pIThumbnail
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreview(
            [In] IWICBitmapSource* pIPreview = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPreview>(lpVtbl->SetPreview)(
                    This,
                    pIPreview
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame(
            [Out] IWICBitmapFrameEncode** ppIFrameEncode = null,
            [In, Out] IPropertyBag2** ppIEncoderOptions = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateNewFrame>(lpVtbl->CreateNewFrame)(
                    This,
                    ppIFrameEncode,
                    ppIEncoderOptions
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(
            [Out] IWICMetadataQueryWriter** ppIMetadataQueryWriter = null
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)(
                    This,
                    ppIMetadataQueryWriter
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Initialize;

            public IntPtr GetContainerFormat;

            public IntPtr GetEncoderInfo;

            public IntPtr SetColorContexts;

            public IntPtr SetPalette;

            public IntPtr SetThumbnail;

            public IntPtr SetPreview;

            public IntPtr CreateNewFrame;

            public IntPtr Commit;

            public IntPtr GetMetadataQueryWriter;
        }
    }
}
