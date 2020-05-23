// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPropertyBag2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyBag2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyBag2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyBag2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IPropertyBag2* pThis, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog, [NativeTypeName("VARIANT *")] VARIANT* pvarValue, [NativeTypeName("HRESULT *")] int* phrError);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(IPropertyBag2* pThis, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("VARIANT *")] VARIANT* pvarValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CountProperties(IPropertyBag2* pThis, [NativeTypeName("ULONG *")] uint* pcProperties);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyInfo(IPropertyBag2* pThis, [NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadObject(IPropertyBag2* pThis, [NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog, [NativeTypeName("VARIANT *")] VARIANT* pvarValue, [NativeTypeName("HRESULT *")] int* phrError)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pErrLog, pvarValue, phrError);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("VARIANT *")] VARIANT* pvarValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CountProperties([NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_CountProperties>(lpVtbl->CountProperties)((IPropertyBag2*)Unsafe.AsPointer(ref this), pcProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, [NativeTypeName("PROPBAG2 *")] PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyInfo>(lpVtbl->GetPropertyInfo)((IPropertyBag2*)Unsafe.AsPointer(ref this), iProperty, cProperties, pPropBag, pcProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadObject>(lpVtbl->LoadObject)((IPropertyBag2*)Unsafe.AsPointer(ref this), pstrName, dwHint, pUnkObject, pErrLog);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, PROPBAG2 *, IErrorLog *, VARIANT *, HRESULT *) __attribute__((stdcall))")]
            public IntPtr Read;

            [NativeTypeName("HRESULT (ULONG, PROPBAG2 *, VARIANT *) __attribute__((stdcall))")]
            public IntPtr Write;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr CountProperties;

            [NativeTypeName("HRESULT (ULONG, ULONG, PROPBAG2 *, ULONG *) __attribute__((stdcall))")]
            public IntPtr GetPropertyInfo;

            [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IUnknown *, IErrorLog *) __attribute__((stdcall))")]
            public IntPtr LoadObject;
        }
    }
}
