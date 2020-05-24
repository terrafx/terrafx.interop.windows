// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcVersionInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcVersionInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcVersionInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcVersionInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IDxcVersionInfo* pThis, [NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFlags(IDxcVersionInfo* pThis, [NativeTypeName("UINT32 *")] uint* pFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlags>(lpVtbl->GetFlags)((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetVersion;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetFlags;
        }
    }
}
