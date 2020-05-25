// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F134C4B7-B1F8-4E75-B886-74B90943BECB")]
    public unsafe partial struct IWinInetFileStream
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWinInetFileStream* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWinInetFileStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWinInetFileStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHandleForUnlock(IWinInetFileStream* pThis, [NativeTypeName("DWORD_PTR")] nuint hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDeleteFile(IWinInetFileStream* pThis, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWinInetFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHandleForUnlock([NativeTypeName("DWORD_PTR")] nuint hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHandleForUnlock>(lpVtbl->SetHandleForUnlock)((IWinInetFileStream*)Unsafe.AsPointer(ref this), hWinInetLockHandle, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDeleteFile([NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDeleteFile>(lpVtbl->SetDeleteFile)((IWinInetFileStream*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD_PTR, DWORD_PTR) __attribute__((stdcall))")]
            public IntPtr SetHandleForUnlock;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public IntPtr SetDeleteFile;
        }
    }
}
