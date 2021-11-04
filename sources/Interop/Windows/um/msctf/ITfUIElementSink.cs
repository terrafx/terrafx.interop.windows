// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA136-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfUIElementSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfUIElementSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint>)(lpVtbl[1]))((ITfUIElementSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint>)(lpVtbl[2]))((ITfUIElementSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginUIElement([NativeTypeName("DWORD")] uint dwUIElementId, BOOL* pbShow)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, BOOL*, int>)(lpVtbl[3]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId, pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UpdateUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, int>)(lpVtbl[4]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementSink*, uint, int>)(lpVtbl[5]))((ITfUIElementSink*)Unsafe.AsPointer(ref this), dwUIElementId);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, uint, BOOL*, int> BeginUIElement;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, uint, int> UpdateUIElement;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElementSink*, uint, int> EndUIElement;
        }
    }
}
