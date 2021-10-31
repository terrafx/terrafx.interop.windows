// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("742B0E01-14E6-101B-914E-00AA00300CAB")]
    [NativeTypeName("struct ISimpleFrameSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISimpleFrameSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISimpleFrameSite*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISimpleFrameSite*, uint>)(lpVtbl[1]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISimpleFrameSite*, uint>)(lpVtbl[2]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PreMessageFilter(HWND hWnd, uint msg, [NativeTypeName("WPARAM")] nuint wp, [NativeTypeName("LPARAM")] nint lp, [NativeTypeName("LRESULT *")] nint* plResult, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ISimpleFrameSite*, HWND, uint, nuint, nint, nint*, uint*, int>)(lpVtbl[3]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT PostMessageFilter(HWND hWnd, uint msg, [NativeTypeName("WPARAM")] nuint wp, [NativeTypeName("LPARAM")] nint lp, [NativeTypeName("LRESULT *")] nint* plResult, [NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ISimpleFrameSite*, HWND, uint, nuint, nint, nint*, uint, int>)(lpVtbl[4]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, dwCookie);
        }
    }
}
