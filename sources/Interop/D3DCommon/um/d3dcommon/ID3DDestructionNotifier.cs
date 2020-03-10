// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3DDestructionNotifier* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3DDestructionNotifier* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3DDestructionNotifier* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterDestructionCallback(ID3DDestructionNotifier* pThis, [NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterDestructionCallback(ID3DDestructionNotifier* pThis, [NativeTypeName("UINT")] uint callbackID);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterDestructionCallback>(lpVtbl->RegisterDestructionCallback)((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback([NativeTypeName("UINT")] uint callbackID)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnregisterDestructionCallback>(lpVtbl->UnregisterDestructionCallback)((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))")]
            public IntPtr RegisterDestructionCallback;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr UnregisterDestructionCallback;
        }
    }
}
