// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CE-0000-0000-C000-000000000046")]
    public unsafe partial struct IComThreadingInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IComThreadingInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IComThreadingInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IComThreadingInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentApartmentType(IComThreadingInfo* pThis, [NativeTypeName("APTTYPE *")] APTTYPE* pAptType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentThreadType(IComThreadingInfo* pThis, [NativeTypeName("THDTYPE *")] THDTYPE* pThreadType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentLogicalThreadId(IComThreadingInfo* pThis, [NativeTypeName("GUID *")] Guid* pguidLogicalThreadId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCurrentLogicalThreadId(IComThreadingInfo* pThis, [NativeTypeName("const GUID &")] Guid* rguid);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IComThreadingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentApartmentType>(lpVtbl->GetCurrentApartmentType)((IComThreadingInfo*)Unsafe.AsPointer(ref this), pAptType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentThreadType([NativeTypeName("THDTYPE *")] THDTYPE* pThreadType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentThreadType>(lpVtbl->GetCurrentThreadType)((IComThreadingInfo*)Unsafe.AsPointer(ref this), pThreadType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguidLogicalThreadId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentLogicalThreadId>(lpVtbl->GetCurrentLogicalThreadId)((IComThreadingInfo*)Unsafe.AsPointer(ref this), pguidLogicalThreadId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCurrentLogicalThreadId>(lpVtbl->SetCurrentLogicalThreadId)((IComThreadingInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (APTTYPE *) __attribute__((stdcall))")]
            public IntPtr GetCurrentApartmentType;

            [NativeTypeName("HRESULT (THDTYPE *) __attribute__((stdcall))")]
            public IntPtr GetCurrentThreadType;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetCurrentLogicalThreadId;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public IntPtr SetCurrentLogicalThreadId;
        }
    }
}
