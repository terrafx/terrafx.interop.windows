// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56AFC-593B-101A-B569-08002B2DBF7A")]
    public unsafe partial struct IRpcStubBuffer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRpcStubBuffer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRpcStubBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRpcStubBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Connect(IRpcStubBuffer* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkServer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Disconnect(IRpcStubBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IRpcStubBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* _prpcmsg, [NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* _pRpcChannelBuffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("IRpcStubBuffer *")]
        public delegate IRpcStubBuffer* _IsIIDSupported(IRpcStubBuffer* pThis, [NativeTypeName("const IID &")] Guid* riid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _CountRefs(IRpcStubBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DebugServerQueryInterface(IRpcStubBuffer* pThis, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DebugServerRelease(IRpcStubBuffer* pThis, [NativeTypeName("void *")] void* pv);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IUnknown *")] IUnknown* pUnkServer)
        {
            return Marshal.GetDelegateForFunctionPointer<_Connect>(lpVtbl->Connect)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pUnkServer);
        }

        public void Disconnect()
        {
            Marshal.GetDelegateForFunctionPointer<_Disconnect>(lpVtbl->Disconnect)((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* _prpcmsg, [NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), _prpcmsg, _pRpcChannelBuffer);
        }

        [return: NativeTypeName("IRpcStubBuffer *")]
        public IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsIIDSupported>(lpVtbl->IsIIDSupported)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid);
        }

        [return: NativeTypeName("ULONG")]
        public uint CountRefs()
        {
            return Marshal.GetDelegateForFunctionPointer<_CountRefs>(lpVtbl->CountRefs)((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DebugServerQueryInterface([NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_DebugServerQueryInterface>(lpVtbl->DebugServerQueryInterface)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), ppv);
        }

        public void DebugServerRelease([NativeTypeName("void *")] void* pv)
        {
            Marshal.GetDelegateForFunctionPointer<_DebugServerRelease>(lpVtbl->DebugServerRelease)((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public IntPtr Connect;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Disconnect;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IRpcChannelBuffer *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("IRpcStubBuffer *(const IID &) __attribute__((stdcall))")]
            public IntPtr IsIIDSupported;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr CountRefs;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public IntPtr DebugServerQueryInterface;

            [NativeTypeName("void (void *) __attribute__((stdcall))")]
            public IntPtr DebugServerRelease;
        }
    }
}
