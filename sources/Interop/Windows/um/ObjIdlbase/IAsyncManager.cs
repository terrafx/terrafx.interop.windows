// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002A-0000-0000-C000-000000000046")]
    public unsafe partial struct IAsyncManager
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAsyncManager* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAsyncManager* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAsyncManager* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CompleteCall(IAsyncManager* pThis, [NativeTypeName("HRESULT")] int Result);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCallContext(IAsyncManager* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetState(IAsyncManager* pThis, [NativeTypeName("ULONG *")] uint* pulStateFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAsyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAsyncManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CompleteCall([NativeTypeName("HRESULT")] int Result)
        {
            return Marshal.GetDelegateForFunctionPointer<_CompleteCall>(lpVtbl->CompleteCall)((IAsyncManager*)Unsafe.AsPointer(ref this), Result);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCallContext>(lpVtbl->GetCallContext)((IAsyncManager*)Unsafe.AsPointer(ref this), riid, pInterface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("ULONG *")] uint* pulStateFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetState>(lpVtbl->GetState)((IAsyncManager*)Unsafe.AsPointer(ref this), pulStateFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public IntPtr CompleteCall;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetCallContext;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr GetState;
        }
    }
}
