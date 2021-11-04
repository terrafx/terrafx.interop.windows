// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D19C834-8879-11D1-83E9-00C04FC2C6D4")]
    [NativeTypeName("struct IOplockStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOplockStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOplockStorage*, Guid*, void**, int>)(lpVtbl[0]))((IOplockStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOplockStorage*, uint>)(lpVtbl[1]))((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOplockStorage*, uint>)(lpVtbl[2]))((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen)
        {
            return ((delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int>)(lpVtbl[3]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OpenStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen)
        {
            return ((delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int>)(lpVtbl[4]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOplockStorage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOplockStorage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOplockStorage*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int> CreateStorageEx;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int> OpenStorageEx;
        }
    }
}
