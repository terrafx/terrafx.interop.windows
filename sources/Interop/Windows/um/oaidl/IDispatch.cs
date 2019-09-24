// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("00020400-0000-0000-C000-000000000046")]
    public unsafe struct IDispatch
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDispatch* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDispatch* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDispatch* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfoCount(
            [In] IDispatch* This,
            [Out, NativeTypeName("UINT")] uint* pctinfo
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTypeInfo(
            [In] IDispatch* This,
            [In, NativeTypeName("UINT")] uint iTInfo,
            [In, NativeTypeName("LCID")] uint lcid,
            [Out] ITypeInfo** ppTInfo = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetIDsOfNames(
            [In] IDispatch* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, NativeTypeName("LPOLESTR[]")] char** rgszNames,
            [In, NativeTypeName("UINT")] uint cNames,
            [In, NativeTypeName("LCID")] uint lcid,
            [Out, NativeTypeName("DISPID[]")] int* rgDispId
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Invoke(
            [In] IDispatch* This,
            [In, NativeTypeName("DISPID")] int dispIdMember,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, NativeTypeName("LCID")] uint lcid,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [In, NativeTypeName("DISPPARAMS[]")] DISPPARAMS* pDispParams,
            [Out] VARIANT* pVarResult = null,
            [Out] EXCEPINFO* pExcepInfo = null,
            [Out, NativeTypeName("UINT")] uint* puArgErr = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDispatch* This = &this)
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
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(
            [Out, NativeTypeName("UINT")] uint* pctinfo
        )
        {
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)(
                    This,
                    pctinfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(
            [In, NativeTypeName("UINT")] uint iTInfo,
            [In, NativeTypeName("LCID")] uint lcid,
            [Out] ITypeInfo** ppTInfo = null
        )
        {
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)(
                    This,
                    iTInfo,
                    lcid,
                    ppTInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, NativeTypeName("LPOLESTR[]")] char** rgszNames,
            [In, NativeTypeName("UINT")] uint cNames,
            [In, NativeTypeName("LCID")] uint lcid,
            [Out, NativeTypeName("DISPID[]")] int* rgDispId
        )
        {
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)(
                    This,
                    riid,
                    rgszNames,
                    cNames,
                    lcid,
                    rgDispId
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke(
            [In, NativeTypeName("DISPID")] int dispIdMember,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, NativeTypeName("LCID")] uint lcid,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [In, NativeTypeName("DISPPARAMS[]")] DISPPARAMS* pDispParams,
            [Out] VARIANT* pVarResult = null,
            [Out] EXCEPINFO* pExcepInfo = null,
            [Out, NativeTypeName("UINT")] uint* puArgErr = null
        )
        {
            fixed (IDispatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)(
                    This,
                    dispIdMember,
                    riid,
                    lcid,
                    wFlags,
                    pDispParams,
                    pVarResult,
                    pExcepInfo,
                    puArgErr
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetTypeInfoCount;

            public IntPtr GetTypeInfo;

            public IntPtr GetIDsOfNames;

            public IntPtr Invoke;
        }
    }
}
