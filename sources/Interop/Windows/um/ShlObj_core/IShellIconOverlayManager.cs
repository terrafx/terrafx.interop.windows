// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F10B5E34-DD3B-42A7-AA7D-2F4EC54BB09B")]
    [NativeTypeName("struct IShellIconOverlayManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellIconOverlayManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, Guid*, void**, int>)(lpVtbl[0]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint>)(lpVtbl[1]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint>)(lpVtbl[2]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFileOverlayInfo([NativeTypeName("PCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib, int* pIndex, [NativeTypeName("DWORD")] uint dwflags)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int>)(lpVtbl[3]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib, pIndex, dwflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetReservedOverlayInfo([NativeTypeName("PCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib, int* pIndex, [NativeTypeName("DWORD")] uint dwflags, int iReservedID)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int, int>)(lpVtbl[4]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib, pIndex, dwflags, iReservedID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RefreshOverlayImages([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint, int>)(lpVtbl[5]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT LoadNonloadedOverlayIdentifiers()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, int>)(lpVtbl[6]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OverlayIndexFromImageIndex(int iImage, int* piIndex, BOOL fAdd)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, int, int*, BOOL, int>)(lpVtbl[7]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), iImage, piIndex, fAdd);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, uint> Release;

            [NativeTypeName("HRESULT (PCWSTR, DWORD, int *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int> GetFileOverlayInfo;

            [NativeTypeName("HRESULT (PCWSTR, DWORD, int *, DWORD, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int, int> GetReservedOverlayInfo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, uint, int> RefreshOverlayImages;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, int> LoadNonloadedOverlayIdentifiers;

            [NativeTypeName("HRESULT (int, int *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellIconOverlayManager*, int, int*, BOOL, int> OverlayIndexFromImageIndex;
        }
    }
}
