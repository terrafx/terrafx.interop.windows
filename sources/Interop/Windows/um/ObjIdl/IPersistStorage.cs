// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010A-0000-0000-C000-000000000046")]
    public unsafe partial struct IPersistStorage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistStorage* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitNew(IPersistStorage* pThis, [NativeTypeName("IStorage *")] IStorage* pStg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistStorage* pThis, [NativeTypeName("IStorage *")] IStorage* pStg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistStorage* pThis, [NativeTypeName("IStorage *")] IStorage* pStgSave, [NativeTypeName("BOOL")] int fSameAsLoad);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveCompleted(IPersistStorage* pThis, [NativeTypeName("IStorage *")] IStorage* pStgNew);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HandsOffStorage(IPersistStorage* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPersistStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IPersistStorage*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitNew>(lpVtbl->InitNew)((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStorage *")] IStorage* pStgSave, [NativeTypeName("BOOL")] int fSameAsLoad)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IPersistStorage*)Unsafe.AsPointer(ref this), pStgSave, fSameAsLoad);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IStorage *")] IStorage* pStgNew)
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveCompleted>(lpVtbl->SaveCompleted)((IPersistStorage*)Unsafe.AsPointer(ref this), pStgNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int HandsOffStorage()
        {
            return Marshal.GetDelegateForFunctionPointer<_HandsOffStorage>(lpVtbl->HandsOffStorage)((IPersistStorage*)Unsafe.AsPointer(ref this));
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
            public IntPtr IsDirty;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public IntPtr InitNew;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (IStorage *, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public IntPtr SaveCompleted;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr HandsOffStorage;
        }
    }
}
