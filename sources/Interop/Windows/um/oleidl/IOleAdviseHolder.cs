// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000111-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleAdviseHolder
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleAdviseHolder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleAdviseHolder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleAdviseHolder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Advise(IOleAdviseHolder* pThis, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unadvise(IOleAdviseHolder* pThis, [NativeTypeName("DWORD")] uint dwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdvise(IOleAdviseHolder* pThis, [NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendOnRename(IOleAdviseHolder* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendOnSave(IOleAdviseHolder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendOnClose(IOleAdviseHolder* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Advise>(lpVtbl->Advise)((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Unadvise>(lpVtbl->Unadvise)((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdvise>(lpVtbl->EnumAdvise)((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_SendOnRename>(lpVtbl->SendOnRename)((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnSave()
        {
            return Marshal.GetDelegateForFunctionPointer<_SendOnSave>(lpVtbl->SendOnSave)((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnClose()
        {
            return Marshal.GetDelegateForFunctionPointer<_SendOnClose>(lpVtbl->SendOnClose)((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public IntPtr Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public IntPtr EnumAdvise;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public IntPtr SendOnRename;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr SendOnSave;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr SendOnClose;
        }
    }
}
