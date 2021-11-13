// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("7CEF04D7-CB75-4E80-A7AB-5F5BC7D332DE")]
    [NativeTypeName("struct IEnumTfDisplayAttributeInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumTfDisplayAttributeInfo : IEnumTfDisplayAttributeInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint>)(lpVtbl[1]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint>)(lpVtbl[2]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Clone(IEnumTfDisplayAttributeInfo** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[3]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfDisplayAttributeInfo** rgInfo, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, ITfDisplayAttributeInfo**, uint*, int>)(lpVtbl[4]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ulCount, rgInfo, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, int>)(lpVtbl[5]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, int>)(lpVtbl[6]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ulCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Clone(IEnumTfDisplayAttributeInfo** ppEnum);

            [VtblIndex(4)]
            HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfDisplayAttributeInfo** rgInfo, [NativeTypeName("ULONG *")] uint* pcFetched);

            [VtblIndex(5)]
            HRESULT Reset();

            [VtblIndex(6)]
            HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint> Release;

            [NativeTypeName("HRESULT (IEnumTfDisplayAttributeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, IEnumTfDisplayAttributeInfo**, int> Clone;

            [NativeTypeName("HRESULT (ULONG, ITfDisplayAttributeInfo **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, ITfDisplayAttributeInfo**, uint*, int> Next;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, int> Reset;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, int> Skip;
        }
    }
}
