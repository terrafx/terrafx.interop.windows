// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4F03DC02-5E6E-4653-8F72-A030C123D598")]
    [NativeTypeName("struct IAudioInputSelector : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioInputSelector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, Guid*, void**, int>)(lpVtbl[0]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint>)(lpVtbl[1]))((IAudioInputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint>)(lpVtbl[2]))((IAudioInputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSelection(uint* pnIdSelected)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint*, int>)(lpVtbl[3]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), pnIdSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSelection(uint nIdSelect, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint, Guid*, int>)(lpVtbl[4]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), nIdSelect, pguidEventContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioInputSelector*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioInputSelector*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioInputSelector*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioInputSelector*, uint*, int> GetSelection;

            [NativeTypeName("HRESULT (UINT, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioInputSelector*, uint, Guid*, int> SetSelection;
        }
    }
}
