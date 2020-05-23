// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000034-0000-0000-C000-000000000046")]
    public unsafe partial struct IInitializeSpy
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInitializeSpy* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInitializeSpy* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInitializeSpy* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PreInitialize(IInitializeSpy* pThis, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PostInitialize(IInitializeSpy* pThis, [NativeTypeName("HRESULT")] int hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PreUninitialize(IInitializeSpy* pThis, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PostUninitialize(IInitializeSpy* pThis, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInitializeSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PreInitialize([NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreInitialize>(lpVtbl->PreInitialize)((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCoInit, dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostInitialize([NativeTypeName("HRESULT")] int hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostInitialize>(lpVtbl->PostInitialize)((IInitializeSpy*)Unsafe.AsPointer(ref this), hrCoInit, dwCoInit, dwNewThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreUninitialize>(lpVtbl->PreUninitialize)((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostUninitialize>(lpVtbl->PostUninitialize)((IInitializeSpy*)Unsafe.AsPointer(ref this), dwNewThreadAptRefs);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr PreInitialize;

            [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr PostInitialize;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr PreUninitialize;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr PostUninitialize;
        }
    }
}
