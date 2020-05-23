// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using InteropMarshal = System.Runtime.InteropServices.Marshal;

namespace TerraFX.Interop
{
    [Guid("0000002D-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeMarshal
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeMarshal* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeMarshal* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeMarshal* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Size(ITypeMarshal* pThis, [NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Marshal(ITypeMarshal* pThis, [NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unmarshal(ITypeMarshal* pThis, [NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Free(ITypeMarshal* pThis, [NativeTypeName("PVOID")] void* pvType);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeMarshal*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Size([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize)
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_Size>(lpVtbl->Size)((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Marshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_Marshal>(lpVtbl->Marshal)((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmarshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, [NativeTypeName("BYTE *")] byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_Unmarshal>(lpVtbl->Unmarshal)((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Free([NativeTypeName("PVOID")] void* pvType)
        {
            return InteropMarshal.GetDelegateForFunctionPointer<_Free>(lpVtbl->Free)((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG *) __attribute__((stdcall))")]
            public IntPtr Size;

            [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Marshal;

            [NativeTypeName("HRESULT (PVOID, DWORD, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Unmarshal;

            [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
            public IntPtr Free;
        }
    }
}
