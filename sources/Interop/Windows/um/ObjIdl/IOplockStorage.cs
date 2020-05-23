// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D19C834-8879-11D1-83E9-00C04FC2C6D4")]
    public unsafe partial struct IOplockStorage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOplockStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOplockStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOplockStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStorageEx(IOplockStorage* pThis, [NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenStorageEx(IOplockStorage* pThis, [NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOplockStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStorageEx>(lpVtbl->CreateStorageEx)((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenStorageEx>(lpVtbl->OpenStorageEx)((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateStorageEx;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr OpenStorageEx;
        }
    }
}
