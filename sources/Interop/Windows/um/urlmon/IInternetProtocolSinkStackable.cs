// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetProtocolSinkStackable
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetProtocolSinkStackable* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetProtocolSinkStackable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetProtocolSinkStackable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SwitchSink(IInternetProtocolSinkStackable* pThis, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CommitSwitch(IInternetProtocolSinkStackable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RollbackSwitch(IInternetProtocolSinkStackable* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SwitchSink([NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_SwitchSink>(lpVtbl->SwitchSink)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), pOIProtSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitSwitch()
        {
            return Marshal.GetDelegateForFunctionPointer<_CommitSwitch>(lpVtbl->CommitSwitch)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RollbackSwitch()
        {
            return Marshal.GetDelegateForFunctionPointer<_RollbackSwitch>(lpVtbl->RollbackSwitch)((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IInternetProtocolSink *) __attribute__((stdcall))")]
            public IntPtr SwitchSink;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr CommitSwitch;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RollbackSwitch;
        }
    }
}
