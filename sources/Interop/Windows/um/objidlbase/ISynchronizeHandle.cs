// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000031-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronizeHandle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISynchronizeHandle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISynchronizeHandle*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISynchronizeHandle*, uint>)(lpVtbl[1]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISynchronizeHandle*, uint>)(lpVtbl[2]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetHandle(HANDLE* ph)
        {
            return ((delegate* unmanaged<ISynchronizeHandle*, HANDLE*, int>)(lpVtbl[3]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this), ph);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeHandle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeHandle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeHandle*, uint> Release;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISynchronizeHandle*, HANDLE*, int> GetHandle;
        }
    }
}
