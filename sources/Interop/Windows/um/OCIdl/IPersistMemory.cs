// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
    public unsafe partial struct IPersistMemory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistMemory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistMemory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistMemory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistMemory* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistMemory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistMemory* pThis, [NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistMemory* pThis, [NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("ULONG")] uint cbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeMax(IPersistMemory* pThis, [NativeTypeName("ULONG *")] uint* pCbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitNew(IPersistMemory* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPersistMemory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IPersistMemory*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IPersistMemory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("ULONG")] uint cbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, fClearDirty, cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)((IPersistMemory*)Unsafe.AsPointer(ref this), pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return Marshal.GetDelegateForFunctionPointer<_InitNew>(lpVtbl->InitNew)((IPersistMemory*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("HRESULT (LPVOID, ULONG) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (LPVOID, BOOL, ULONG) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr GetSizeMax;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr InitNew;
        }
    }
}
