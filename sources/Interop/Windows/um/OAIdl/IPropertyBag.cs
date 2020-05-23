// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
    public unsafe partial struct IPropertyBag
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyBag* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyBag* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyBag* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IPropertyBag* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(IPropertyBag* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *, IErrorLog *) __attribute__((stdcall))")]
            public IntPtr Read;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public IntPtr Write;
        }
    }
}
