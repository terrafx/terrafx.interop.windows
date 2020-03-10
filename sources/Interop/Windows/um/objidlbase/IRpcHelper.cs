// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000149-0000-0000-C000-000000000046")]
    public unsafe partial struct IRpcHelper
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRpcHelper* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRpcHelper* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRpcHelper* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDCOMProtocolVersion(IRpcHelper* pThis, [NativeTypeName("DWORD *")] uint* pComVersion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIIDFromOBJREF(IRpcHelper* pThis, [NativeTypeName("void *")] void* pObjRef, [NativeTypeName("IID **")] Guid** piid);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRpcHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDCOMProtocolVersion([NativeTypeName("DWORD *")] uint* pComVersion)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDCOMProtocolVersion>(lpVtbl->GetDCOMProtocolVersion)((IRpcHelper*)Unsafe.AsPointer(ref this), pComVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIIDFromOBJREF([NativeTypeName("void *")] void* pObjRef, [NativeTypeName("IID **")] Guid** piid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIIDFromOBJREF>(lpVtbl->GetIIDFromOBJREF)((IRpcHelper*)Unsafe.AsPointer(ref this), pObjRef, piid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetDCOMProtocolVersion;

            [NativeTypeName("HRESULT (void *, IID **) __attribute__((stdcall))")]
            public IntPtr GetIIDFromOBJREF;
        }
    }
}
