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
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    [Unmanaged]
    public unsafe struct IWICColorContext
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICColorContext* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICColorContext* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICColorContext* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromFilename(
            [In] IWICColorContext* This,
            [In, NativeTypeName("LPCWSTR")] char* wzFilename
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromMemory(
            [In] IWICColorContext* This,
            [In, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [In, NativeTypeName("UINT")] uint cbBufferSize
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromExifColorSpace(
            [In] IWICColorContext* This,
            [In, NativeTypeName("UINT")] uint value
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int __GetType(
            [In] IWICColorContext* This,
            [Out] WICColorContextType* pType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetProfileBytes(
            [In] IWICColorContext* This,
            [In, NativeTypeName("UINT")] uint cbBuffer,
            [In, Out, Optional, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [Out, NativeTypeName("UINT")] uint* pcbActual
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetExifColorSpace(
            [In] IWICColorContext* This,
            [Out, NativeTypeName("UINT")] uint* pValue
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICColorContext* This = &this)
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
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename(
            [In, NativeTypeName("LPCWSTR")] char* wzFilename
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_InitializeFromFilename>(lpVtbl->InitializeFromFilename)(
                    This,
                    wzFilename
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory(
            [In, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [In, NativeTypeName("UINT")] uint cbBufferSize
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_InitializeFromMemory>(lpVtbl->InitializeFromMemory)(
                    This,
                    pbBuffer,
                    cbBufferSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace(
            [In, NativeTypeName("UINT")] uint value
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_InitializeFromExifColorSpace>(lpVtbl->InitializeFromExifColorSpace)(
                    This,
                    value
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int _GetType(
            [Out] WICColorContextType* pType
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<__GetType>(lpVtbl->_GetType)(
                    This,
                    pType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes(
            [In, NativeTypeName("UINT")] uint cbBuffer,
            [In, Out, Optional, NativeTypeName("BYTE[]")] byte* pbBuffer,
            [Out, NativeTypeName("UINT")] uint* pcbActual
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_GetProfileBytes>(lpVtbl->GetProfileBytes)(
                    This,
                    cbBuffer,
                    pbBuffer,
                    pcbActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace(
            [Out, NativeTypeName("UINT")] uint* pValue
        )
        {
            fixed (IWICColorContext* This = &this)
            {
                return MarshalFunction<_GetExifColorSpace>(lpVtbl->GetExifColorSpace)(
                    This,
                    pValue
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
            public IntPtr InitializeFromFilename;

            public IntPtr InitializeFromMemory;

            public IntPtr InitializeFromExifColorSpace;

            public IntPtr _GetType;

            public IntPtr GetProfileBytes;

            public IntPtr GetExifColorSpace;
            #endregion
        }
        #endregion
    }
}
