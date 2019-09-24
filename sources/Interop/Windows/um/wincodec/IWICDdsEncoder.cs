// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    public unsafe struct IWICDdsEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICDdsEncoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICDdsEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICDdsEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetParameters(
            [In] IWICDdsEncoder* This,
            [In] WICDdsParameters* pParameters
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParameters(
            [In] IWICDdsEncoder* This,
            [Out] WICDdsParameters* pParameters
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateNewFrame(
            [In] IWICDdsEncoder* This,
            [Out] IWICBitmapFrameEncode** ppIFrameEncode = null,
            [Out, NativeTypeName("UINT")] uint* pArrayIndex = null,
            [Out, NativeTypeName("UINT")] uint* pMipLevel = null,
            [Out, NativeTypeName("UINT")] uint* pSliceIndex = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICDdsEncoder* This = &this)
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
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParameters(
            [In] WICDdsParameters* pParameters
        )
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetParameters>(lpVtbl->SetParameters)(
                    This,
                    pParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters(
            [Out] WICDdsParameters* pParameters
        )
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)(
                    This,
                    pParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame(
            [Out] IWICBitmapFrameEncode** ppIFrameEncode = null,
            [Out, NativeTypeName("UINT")] uint* pArrayIndex = null,
            [Out, NativeTypeName("UINT")] uint* pMipLevel = null,
            [Out, NativeTypeName("UINT")] uint* pSliceIndex = null
        )
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateNewFrame>(lpVtbl->CreateNewFrame)(
                    This,
                    ppIFrameEncode,
                    pArrayIndex,
                    pMipLevel,
                    pSliceIndex
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetParameters;

            public IntPtr GetParameters;

            public IntPtr CreateNewFrame;
        }
    }
}
