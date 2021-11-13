// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("947990DE-CC28-11D2-A0F7-00805F858FB1")]
    [NativeTypeName("struct IDummyHICONIncluder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDummyHICONIncluder : IDummyHICONIncluder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDummyHICONIncluder*, Guid*, void**, int>)(lpVtbl[0]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDummyHICONIncluder*, uint>)(lpVtbl[1]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDummyHICONIncluder*, uint>)(lpVtbl[2]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Dummy(HICON h1, HDC h2)
        {
            return ((delegate* unmanaged<IDummyHICONIncluder*, HICON, HDC, int>)(lpVtbl[3]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this), h1, h2);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Dummy(HICON h1, HDC h2);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDummyHICONIncluder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDummyHICONIncluder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDummyHICONIncluder*, uint> Release;

            [NativeTypeName("HRESULT (HICON, HDC) __attribute__((stdcall))")]
            public delegate* unmanaged<IDummyHICONIncluder*, HICON, HDC, int> Dummy;
        }
    }
}
