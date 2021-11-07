// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
    [NativeTypeName("struct ICreateDevEnum : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICreateDevEnum : ICreateDevEnum.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateDevEnum*, Guid*, void**, int>)(lpVtbl[0]))((ICreateDevEnum*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateDevEnum*, uint>)(lpVtbl[1]))((ICreateDevEnum*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateDevEnum*, uint>)(lpVtbl[2]))((ICreateDevEnum*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateClassEnumerator([NativeTypeName("const IID &")] Guid* clsidDeviceClass, IEnumMoniker** ppEnumMoniker, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ICreateDevEnum*, Guid*, IEnumMoniker**, uint, int>)(lpVtbl[3]))((ICreateDevEnum*)Unsafe.AsPointer(ref this), clsidDeviceClass, ppEnumMoniker, dwFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateClassEnumerator([NativeTypeName("const IID &")] Guid* clsidDeviceClass, IEnumMoniker** ppEnumMoniker, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateDevEnum*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateDevEnum*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateDevEnum*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, IEnumMoniker **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateDevEnum*, Guid*, IEnumMoniker**, uint, int> CreateClassEnumerator;
        }
    }
}
