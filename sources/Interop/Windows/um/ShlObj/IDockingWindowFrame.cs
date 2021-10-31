// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("47D2657A-7B27-11D0-8CA9-00A0C92DBFE8")]
    [NativeTypeName("struct IDockingWindowFrame : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDockingWindowFrame
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, Guid*, void**, int>)(lpVtbl[0]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, uint>)(lpVtbl[1]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, uint>)(lpVtbl[2]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow(HWND* phwnd)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, HWND*, int>)(lpVtbl[3]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, BOOL, int>)(lpVtbl[4]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddToolbar(IUnknown* punkSrc, [NativeTypeName("PCWSTR")] ushort* pwszItem, [NativeTypeName("DWORD")] uint dwAddFlags)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, IUnknown*, ushort*, uint, int>)(lpVtbl[5]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), punkSrc, pwszItem, dwAddFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveToolbar(IUnknown* punkSrc, [NativeTypeName("DWORD")] uint dwRemoveFlags)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, IUnknown*, uint, int>)(lpVtbl[6]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), punkSrc, dwRemoveFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT FindToolbar([NativeTypeName("PCWSTR")] ushort* pwszItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDockingWindowFrame*, ushort*, Guid*, void**, int>)(lpVtbl[7]))((IDockingWindowFrame*)Unsafe.AsPointer(ref this), pwszItem, riid, ppv);
        }
    }
}
