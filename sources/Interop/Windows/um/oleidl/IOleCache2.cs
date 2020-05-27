// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000128-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleCache2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleCache2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleCache2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleCache2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Cache(IOleCache2* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Uncache(IOleCache2* pThis, [NativeTypeName("DWORD")] uint dwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumCache(IOleCache2* pThis, [NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumSTATDATA);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitCache(IOleCache2* pThis, [NativeTypeName("IDataObject *")] IDataObject* pDataObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetData(IOleCache2* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateCache(IOleCache2* pThis, [NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DiscardCache(IOleCache2* pThis, [NativeTypeName("DWORD")] uint dwDiscardOptions);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleCache2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Cache([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Cache>(lpVtbl->Cache)((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Uncache([NativeTypeName("DWORD")] uint dwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Uncache>(lpVtbl->Uncache)((IOleCache2*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumCache([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumSTATDATA)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumCache>(lpVtbl->EnumCache)((IOleCache2*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitCache([NativeTypeName("IDataObject *")] IDataObject* pDataObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitCache>(lpVtbl->InitCache)((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetData>(lpVtbl->SetData)((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateCache([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdateCache>(lpVtbl->UpdateCache)((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject, grfUpdf, pReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardCache([NativeTypeName("DWORD")] uint dwDiscardOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_DiscardCache>(lpVtbl->DiscardCache)((IOleCache2*)Unsafe.AsPointer(ref this), dwDiscardOptions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (FORMATETC *, DWORD, DWORD *) __attribute__((stdcall))")]
            public IntPtr Cache;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Uncache;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public IntPtr EnumCache;

            [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
            public IntPtr InitCache;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
            public IntPtr SetData;

            [NativeTypeName("HRESULT (LPDATAOBJECT, DWORD, LPVOID) __attribute__((stdcall))")]
            public IntPtr UpdateCache;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr DiscardCache;
        }
    }
}
