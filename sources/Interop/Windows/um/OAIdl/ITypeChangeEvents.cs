// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020410-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeChangeEvents
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeChangeEvents* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeChangeEvents* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeChangeEvents* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestTypeChange(ITypeChangeEvents* pThis, CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, [NativeTypeName("INT *")] int* pfCancel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AfterTypeChange(ITypeChangeEvents* pThis, CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeChangeEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, [NativeTypeName("INT *")] int* pfCancel)
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestTypeChange>(lpVtbl->RequestTypeChange)((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoBefore, pStrName, pfCancel);
        }

        [return: NativeTypeName("HRESULT")]
        public int AfterTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName)
        {
            return Marshal.GetDelegateForFunctionPointer<_AfterTypeChange>(lpVtbl->AfterTypeChange)((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoAfter, pStrName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR, INT *) __attribute__((stdcall))")]
            public IntPtr RequestTypeChange;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR) __attribute__((stdcall))")]
            public IntPtr AfterTypeChange;
        }
    }
}
