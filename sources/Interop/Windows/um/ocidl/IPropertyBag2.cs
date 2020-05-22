// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55882-280B-11d0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPropertyBag2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyBag2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyBag2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyBag2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IPropertyBag2* This, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag, [Optional] IErrorLog* pErrLog, VARIANT* pvarValue, [NativeTypeName("HRESULT")] int* phrError = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(IPropertyBag2* This, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag, VARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CountProperties(IPropertyBag2* This, [NativeTypeName("ULONG")] uint* pcProperties);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyInfo(IPropertyBag2* This, [NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2")] PROPBAG2* pPropBag, [NativeTypeName("ULONG")] uint* pcProperties);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadObject(IPropertyBag2* This, [NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, IUnknown* pUnkObject = null, IErrorLog* pErrLog = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag, [Optional] IErrorLog* pErrLog, VARIANT* pvarValue, [NativeTypeName("HRESULT")] int* phrError = null)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)(This, cProperties, pPropBag, pErrLog, pvarValue, phrError);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2[]")] PROPBAG2* pPropBag, VARIANT* pvarValue)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)(This, cProperties, pPropBag, pvarValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CountProperties([NativeTypeName("ULONG")] uint* pcProperties)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CountProperties>(lpVtbl->CountProperties)(This, pcProperties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2")] PROPBAG2* pPropBag, [NativeTypeName("ULONG")] uint* pcProperties)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyInfo>(lpVtbl->GetPropertyInfo)(This, iProperty, cProperties, pPropBag, pcProperties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, IUnknown* pUnkObject = null, IErrorLog* pErrLog = null)
        {
            fixed (IPropertyBag2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadObject>(lpVtbl->LoadObject)(This, pstrName, dwHint, pUnkObject, pErrLog);
            }
        }

        public partial struct Vtbl
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
