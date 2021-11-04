// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000012B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDropSourceNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDropSourceNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDropSourceNotify*, Guid*, void**, int>)(lpVtbl[0]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDropSourceNotify*, uint>)(lpVtbl[1]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDropSourceNotify*, uint>)(lpVtbl[2]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DragEnterTarget(HWND hwndTarget)
        {
            return ((delegate* unmanaged<IDropSourceNotify*, HWND, int>)(lpVtbl[3]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), hwndTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DragLeaveTarget()
        {
            return ((delegate* unmanaged<IDropSourceNotify*, int>)(lpVtbl[4]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropSourceNotify*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropSourceNotify*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropSourceNotify*, uint> Release;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<IDropSourceNotify*, HWND, int> DragEnterTarget;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDropSourceNotify*, int> DragLeaveTarget;
        }
    }
}
