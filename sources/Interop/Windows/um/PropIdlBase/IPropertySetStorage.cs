// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013A-0000-0000-C000-000000000046")]
    public unsafe partial struct IPropertySetStorage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertySetStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertySetStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertySetStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Create(IPropertySetStorage* pThis, [NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(IPropertySetStorage* pThis, [NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Delete(IPropertySetStorage* pThis, [NativeTypeName("const IID &")] Guid* rfmtid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Enum(IPropertySetStorage* pThis, [NativeTypeName("IEnumSTATPROPSETSTG **")] IEnumSTATPROPSETSTG** ppenum);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertySetStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg)
        {
            return Marshal.GetDelegateForFunctionPointer<_Create>(lpVtbl->Create)((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, pclsid, grfFlags, grfMode, ppprstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg)
        {
            return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, grfMode, ppprstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Delete([NativeTypeName("const IID &")] Guid* rfmtid)
        {
            return Marshal.GetDelegateForFunctionPointer<_Delete>(lpVtbl->Delete)((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("IEnumSTATPROPSETSTG **")] IEnumSTATPROPSETSTG** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_Enum>(lpVtbl->Enum)((IPropertySetStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const IID &, const CLSID *, DWORD, DWORD, IPropertyStorage **) __attribute__((stdcall))")]
            public IntPtr Create;

            [NativeTypeName("HRESULT (const IID &, DWORD, IPropertyStorage **) __attribute__((stdcall))")]
            public IntPtr Open;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public IntPtr Delete;

            [NativeTypeName("HRESULT (IEnumSTATPROPSETSTG **) __attribute__((stdcall))")]
            public IntPtr Enum;
        }
    }
}
