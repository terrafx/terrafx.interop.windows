// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("587A461C-B80B-4F54-9194-5032589A6319")]
    [NativeTypeName("struct IDiaReadExeAtOffsetCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaReadExeAtOffsetCallback : IDiaReadExeAtOffsetCallback.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback*, uint>)(lpVtbl[1]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback*, uint>)(lpVtbl[2]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReadExecutableAt([NativeTypeName("DWORDLONG")] ulong fileOffset, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
        {
            return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback*, ulong, uint, uint*, byte*, int>)(lpVtbl[3]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this), fileOffset, cbData, pcbData, pbData);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ReadExecutableAt([NativeTypeName("DWORDLONG")] ulong fileOffset, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaReadExeAtOffsetCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaReadExeAtOffsetCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaReadExeAtOffsetCallback*, uint> Release;

            [NativeTypeName("HRESULT (DWORDLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaReadExeAtOffsetCallback*, ulong, uint, uint*, byte*, int> ReadExecutableAt;
        }
    }
}
