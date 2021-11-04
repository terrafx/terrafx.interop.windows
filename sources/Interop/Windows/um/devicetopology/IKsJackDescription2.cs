// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("478F3A9B-E0C9-4827-9228-6F5505FFE76A")]
    [NativeTypeName("struct IKsJackDescription2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IKsJackDescription2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKsJackDescription2*, Guid*, void**, int>)(lpVtbl[0]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKsJackDescription2*, uint>)(lpVtbl[1]))((IKsJackDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKsJackDescription2*, uint>)(lpVtbl[2]))((IKsJackDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetJackCount(uint* pcJacks)
        {
            return ((delegate* unmanaged<IKsJackDescription2*, uint*, int>)(lpVtbl[3]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), pcJacks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetJackDescription2(uint nJack, KSJACK_DESCRIPTION2* pDescription2)
        {
            return ((delegate* unmanaged<IKsJackDescription2*, uint, KSJACK_DESCRIPTION2*, int>)(lpVtbl[4]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), nJack, pDescription2);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IKsJackDescription2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IKsJackDescription2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IKsJackDescription2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKsJackDescription2*, uint*, int> GetJackCount;

            [NativeTypeName("HRESULT (UINT, KSJACK_DESCRIPTION2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IKsJackDescription2*, uint, KSJACK_DESCRIPTION2*, int> GetJackDescription2;
        }
    }
}
