// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IPersistMoniker
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistMoniker* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistMoniker* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistMoniker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistMoniker* pThis, [NativeTypeName("BOOL")] int fFullyAvailable, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveCompleted(IPersistMoniker* pThis, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurMoniker(IPersistMoniker* pThis, [NativeTypeName("IMoniker **")] IMoniker** ppimkName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("BOOL")] int fFullyAvailable, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveCompleted>(lpVtbl->SaveCompleted)((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurMoniker([NativeTypeName("IMoniker **")] IMoniker** ppimkName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurMoniker>(lpVtbl->GetCurMoniker)((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
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

            [NativeTypeName("HRESULT (BOOL, IMoniker *, LPBC, DWORD) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
            public IntPtr SaveCompleted;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public IntPtr GetCurMoniker;
        }
    }
}
