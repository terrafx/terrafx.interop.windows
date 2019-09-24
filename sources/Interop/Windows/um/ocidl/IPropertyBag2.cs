// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\ocidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55882-280B-11d0-A8A9-00A0C90C2004")]
    public unsafe struct IPropertyBag2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IPropertyBag2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IPropertyBag2* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IPropertyBag2* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(
            [In] IPropertyBag2* This,
            [In, NativeTypeName("ULONG")] uint cProperties,
            [In, NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag,
            [In, Optional] IErrorLog* pErrLog,
            [Out] VARIANT* pvarValue,
            [In, Out, NativeTypeName("HRESULT")] int* phrError = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(
            [In] IPropertyBag2* This,
            [In, NativeTypeName("ULONG")] uint cProperties,
            [In, NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag,
            [In] VARIANT* pvarValue
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CountProperties(
            [In] IPropertyBag2* This,
            [Out, NativeTypeName("ULONG")] uint* pcProperties
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyInfo(
            [In] IPropertyBag2* This,
            [In, NativeTypeName("ULONG")] uint iProperty,
            [In, NativeTypeName("ULONG")] uint cProperties,
            [Out, NativeTypeName("PROPBAG2")] PROPBAG2* pPropBag,
            [Out, NativeTypeName("ULONG")] uint* pcProperties
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadObject(
            [In] IPropertyBag2* This,
            [In, NativeTypeName("LPCOLESTR")] char* pstrName,
            [In, NativeTypeName("DWORD")] uint dwHint,
            [In] IUnknown* pUnkObject = null,
            [In] IErrorLog* pErrLog = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IPropertyBag2* This = &this)
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
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Read(
            [In, NativeTypeName("ULONG")] uint cProperties,
            [In, NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag,
            [In, Optional] IErrorLog* pErrLog,
            [Out] VARIANT* pvarValue,
            [In, Out, NativeTypeName("HRESULT")] int* phrError = null
        )
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)(
                    This,
                    cProperties,
                    pPropBag,
                    pErrLog,
                    pvarValue,
                    phrError
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Write(
            [In, NativeTypeName("ULONG")] uint cProperties,
            [In, NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag,
            [In] VARIANT* pvarValue
        )
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)(
                    This,
                    cProperties,
                    pPropBag,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CountProperties(
            [Out, NativeTypeName("ULONG")] uint* pcProperties
        )
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CountProperties>(lpVtbl->CountProperties)(
                    This,
                    pcProperties
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyInfo(
            [In, NativeTypeName("ULONG")] uint iProperty,
            [In, NativeTypeName("ULONG")] uint cProperties,
            [Out, NativeTypeName("PROPBAG2")] PROPBAG2* pPropBag,
            [Out, NativeTypeName("ULONG")] uint* pcProperties
        )
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyInfo>(lpVtbl->GetPropertyInfo)(
                    This,
                    iProperty,
                    cProperties,
                    pPropBag,
                    pcProperties
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadObject(
            [In, NativeTypeName("LPCOLESTR")] char* pstrName,
            [In, NativeTypeName("DWORD")] uint dwHint,
            [In] IUnknown* pUnkObject = null,
            [In] IErrorLog* pErrLog = null
        )
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadObject>(lpVtbl->LoadObject)(
                    This,
                    pstrName,
                    dwHint,
                    pUnkObject,
                    pErrLog
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Read;

            public IntPtr Write;

            public IntPtr CountProperties;

            public IntPtr GetPropertyInfo;

            public IntPtr LoadObject;
        }
    }
}
