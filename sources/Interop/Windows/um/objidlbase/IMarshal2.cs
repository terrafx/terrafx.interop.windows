// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CF-0000-0000-C000-000000000046")]
    public unsafe partial struct IMarshal2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IMarshal2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IMarshal2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IMarshal2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnmarshalClass(IMarshal2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMarshalSizeMax(IMarshal2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MarshalInterface(IMarshal2* pThis, [NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnmarshalInterface(IMarshal2* pThis, [NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseMarshalData(IMarshal2* pThis, [NativeTypeName("IStream *")] IStream* pStm);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DisconnectObject(IMarshal2* pThis, [NativeTypeName("DWORD")] uint dwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IMarshal2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnmarshalClass>(lpVtbl->GetUnmarshalClass)((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMarshalSizeMax>(lpVtbl->GetMarshalSizeMax)((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int MarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return Marshal.GetDelegateForFunctionPointer<_MarshalInterface>(lpVtbl->MarshalInterface)((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnmarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnmarshalInterface>(lpVtbl->UnmarshalInterface)((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalData([NativeTypeName("IStream *")] IStream* pStm)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseMarshalData>(lpVtbl->ReleaseMarshalData)((IMarshal2*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_DisconnectObject>(lpVtbl->DisconnectObject)((IMarshal2*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, CLSID *) __attribute__((stdcall))")]
            public IntPtr GetUnmarshalClass;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetMarshalSizeMax;

            [NativeTypeName("HRESULT (IStream *, const IID &, void *, DWORD, void *, DWORD) __attribute__((stdcall))")]
            public IntPtr MarshalInterface;

            [NativeTypeName("HRESULT (IStream *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr UnmarshalInterface;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public IntPtr ReleaseMarshalData;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr DisconnectObject;
        }
    }
}
