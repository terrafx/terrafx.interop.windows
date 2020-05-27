// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000110-0000-0000-C000-000000000046")]
    public unsafe partial struct IDataAdviseHolder
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDataAdviseHolder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDataAdviseHolder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDataAdviseHolder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Advise(IDataAdviseHolder* pThis, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("FORMATETC *")] FORMATETC* pFetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unadvise(IDataAdviseHolder* pThis, [NativeTypeName("DWORD")] uint dwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdvise(IDataAdviseHolder* pThis, [NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendOnDataChange(IDataAdviseHolder* pThis, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint advf);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDataAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("FORMATETC *")] FORMATETC* pFetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Advise>(lpVtbl->Advise)((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, pFetc, advf, pAdvise, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Unadvise>(lpVtbl->Unadvise)((IDataAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdvise>(lpVtbl->EnumAdvise)((IDataAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnDataChange([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint advf)
        {
            return Marshal.GetDelegateForFunctionPointer<_SendOnDataChange>(lpVtbl->SendOnDataChange)((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, dwReserved, advf);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDataObject *, FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public IntPtr Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public IntPtr EnumAdvise;

            [NativeTypeName("HRESULT (IDataObject *, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr SendOnDataChange;
        }
    }
}
