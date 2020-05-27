// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55881-280B-11D0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPersistPropertyBag2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistPropertyBag2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistPropertyBag2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistPropertyBag2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistPropertyBag2* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitNew(IPersistPropertyBag2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistPropertyBag2* pThis, [NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistPropertyBag2* pThis, [NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistPropertyBag2* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return Marshal.GetDelegateForFunctionPointer<_InitNew>(lpVtbl->InitNew)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, pErrLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public IntPtr GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr InitNew;

            [NativeTypeName("HRESULT (IPropertyBag2 *, IErrorLog *) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (IPropertyBag2 *, BOOL, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsDirty;
        }
    }
}
