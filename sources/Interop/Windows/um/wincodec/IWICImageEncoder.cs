// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
    [Unmanaged]
    public unsafe struct IWICImageEncoder
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICImageEncoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICImageEncoder* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICImageEncoder* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WriteFrame(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WriteFrameThumbnail(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _WriteThumbnail(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapEncoder* pEncoder,
            [In] WICImageParameters* pImageParameters
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICImageEncoder* This = &this)
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
            fixed (IWICImageEncoder* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int WriteFrame(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return MarshalFunction<_WriteFrame>(lpVtbl->WriteFrame)(
                    This,
                    pImage,
                    pFrameEncode,
                    pImageParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return MarshalFunction<_WriteFrameThumbnail>(lpVtbl->WriteFrameThumbnail)(
                    This,
                    pImage,
                    pFrameEncode,
                    pImageParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapEncoder* pEncoder,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return MarshalFunction<_WriteThumbnail>(lpVtbl->WriteThumbnail)(
                    This,
                    pImage,
                    pEncoder,
                    pImageParameters
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

            #region Fields
            public IntPtr WriteFrame;

            public IntPtr WriteFrameThumbnail;

            public IntPtr WriteThumbnail;
            #endregion
        }
        #endregion
    }
}
