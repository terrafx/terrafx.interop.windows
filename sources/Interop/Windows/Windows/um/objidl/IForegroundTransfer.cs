// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00000145-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IForegroundTransfer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IForegroundTransfer : IForegroundTransfer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IForegroundTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IForegroundTransfer*, uint>)(lpVtbl[1]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IForegroundTransfer*, uint>)(lpVtbl[2]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AllowForegroundTransfer(void* lpvReserved)
        {
            return ((delegate* unmanaged<IForegroundTransfer*, void*, int>)(lpVtbl[3]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), lpvReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AllowForegroundTransfer(void* lpvReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IForegroundTransfer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IForegroundTransfer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IForegroundTransfer*, uint> Release;

            [NativeTypeName("HRESULT (void *) __attribute__((stdcall))")]
            public delegate* unmanaged<IForegroundTransfer*, void*, int> AllowForegroundTransfer;
        }
    }
}
