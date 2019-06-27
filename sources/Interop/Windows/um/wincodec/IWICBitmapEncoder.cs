// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICBitmapEncoder
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapEncoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapEncoder* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapEncoder* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Initialize(
            [In] IWICBitmapEncoder* This,
            [In, Optional] IStream* pIStream,
            [In] WICBitmapEncoderCacheOption cacheOption
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormat(
            [In] IWICBitmapEncoder* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEncoderInfo(
            [In] IWICBitmapEncoder* This,
            [Out] IWICBitmapEncoderInfo** ppIEncoderInfo = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetColorContexts(
            [In] IWICBitmapEncoder* This,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContext
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPalette(
            [In] IWICBitmapEncoder* This,
            [In] IWICPalette* pIPalette = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetThumbnail(
            [In] IWICBitmapEncoder* This,
            [In] IWICBitmapSource* pIThumbnail = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPreview(
            [In] IWICBitmapEncoder* This,
            [In] IWICBitmapSource* pIPreview = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateNewFrame(
            [In] IWICBitmapEncoder* This,
            [Out] IWICBitmapFrameEncode** ppIFrameEncode = null,
            [In, Out] IPropertyBag2** ppIEncoderOptions = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Commit(
            [In] IWICBitmapEncoder* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataQueryWriter(
            [In] IWICBitmapEncoder* This,
            [Out] IWICMetadataQueryWriter** ppIMetadataQueryWriter = null
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
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
            fixed (IWICBitmapEncoder* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int Initialize(
            [In, Optional] IStream* pIStream,
            [In] WICBitmapEncoderCacheOption cacheOption
        )
        {
            fixed (IWICBitmapEncoder* This = &this)
            {
                return MarshalFunction<_Initialize>(lpVtbl->Initialize)(
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
                return MarshalFunction<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
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
                return MarshalFunction<_GetEncoderInfo>(lpVtbl->GetEncoderInfo)(
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
                return MarshalFunction<_SetColorContexts>(lpVtbl->SetColorContexts)(
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
                return MarshalFunction<_SetPalette>(lpVtbl->SetPalette)(
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
                return MarshalFunction<_SetThumbnail>(lpVtbl->SetThumbnail)(
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
                return MarshalFunction<_SetPreview>(lpVtbl->SetPreview)(
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
                return MarshalFunction<_CreateNewFrame>(lpVtbl->CreateNewFrame)(
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
                return MarshalFunction<_Commit>(lpVtbl->Commit)(
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
                return MarshalFunction<_GetMetadataQueryWriter>(lpVtbl->GetMetadataQueryWriter)(
                    This,
                    ppIMetadataQueryWriter
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
            #endregion
        }
        #endregion
    }
}
