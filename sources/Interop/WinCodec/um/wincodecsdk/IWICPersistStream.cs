// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICPersistStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPersistStream* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPersistStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPersistStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IWICPersistStream* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IWICPersistStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IWICPersistStream* pThis, [NativeTypeName("IStream *")] IStream* pStm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IWICPersistStream* pThis, [NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeMax(IWICPersistStream* pThis, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadEx(IWICPersistStream* pThis, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveEx(IWICPersistStream* pThis, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadEx([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadEx>(lpVtbl->LoadEx)((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveEx([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveEx>(lpVtbl->SaveEx)((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
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

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr GetSizeMax;

            [NativeTypeName("HRESULT (IStream *, const GUID *, DWORD) __attribute__((stdcall))")]
            public IntPtr LoadEx;

            [NativeTypeName("HRESULT (IStream *, DWORD, BOOL) __attribute__((stdcall))")]
            public IntPtr SaveEx;
        }
    }
}
