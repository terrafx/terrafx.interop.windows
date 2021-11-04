// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("06B64F9E-7FDA-11D2-B4F2-00C04F797396")]
    [NativeTypeName("struct IEnumSpObjectTokens : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSpObjectTokens : IEnumSpObjectTokens.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint>)(lpVtbl[1]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint>)(lpVtbl[2]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, ISpObjectToken** pelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint, ISpObjectToken**, uint*, int>)(lpVtbl[3]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), celt, pelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint, int>)(lpVtbl[4]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, int>)(lpVtbl[5]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumSpObjectTokens** ppEnum)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, IEnumSpObjectTokens**, int>)(lpVtbl[6]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Item([NativeTypeName("ULONG")] uint Index, ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint, ISpObjectToken**, int>)(lpVtbl[7]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), Index, ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCount([NativeTypeName("ULONG *")] uint* pCount)
        {
            return ((delegate* unmanaged<IEnumSpObjectTokens*, uint*, int>)(lpVtbl[8]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), pCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, ISpObjectToken** pelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(4)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(5)]
            HRESULT Reset();

            [VtblIndex(6)]
            HRESULT Clone(IEnumSpObjectTokens** ppEnum);

            [VtblIndex(7)]
            HRESULT Item([NativeTypeName("ULONG")] uint Index, ISpObjectToken** ppToken);

            [VtblIndex(8)]
            HRESULT GetCount([NativeTypeName("ULONG *")] uint* pCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, ISpObjectToken **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint, ISpObjectToken**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, int> Reset;

            [NativeTypeName("HRESULT (IEnumSpObjectTokens **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, IEnumSpObjectTokens**, int> Clone;

            [NativeTypeName("HRESULT (ULONG, ISpObjectToken **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint, ISpObjectToken**, int> Item;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSpObjectTokens*, uint*, int> GetCount;
        }
    }
}
