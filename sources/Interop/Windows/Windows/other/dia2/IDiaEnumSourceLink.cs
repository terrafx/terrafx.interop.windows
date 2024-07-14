// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink"]/*' />
[Guid("45CD1EB3-5C6C-43E3-B20A-A4D8035DE4E2")]
[NativeTypeName("struct IDiaEnumSourceLink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSourceLink : IDiaEnumSourceLink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSourceLink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint>)(lpVtbl[1]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint>)(lpVtbl[2]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint*, int>)(lpVtbl[3]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), pCnt);
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.SizeOfNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint*, int>)(lpVtbl[4]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Next([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, byte* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), cb, pcb, pb);
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("DWORD")] uint cnt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, uint, int>)(lpVtbl[6]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), cnt);
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, int>)(lpVtbl[7]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSourceLink.xml' path='doc/member[@name="IDiaEnumSourceLink.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSourceLink** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink*, IDiaEnumSourceLink**, int>)(lpVtbl[8]))((IDiaEnumSourceLink*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt);

        [VtblIndex(4)]
        HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(5)]
        HRESULT Next([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, byte* pb);

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("DWORD")] uint cnt);

        [VtblIndex(7)]
        HRESULT Reset();

        [VtblIndex(8)]
        HRESULT Clone(IDiaEnumSourceLink** ppenum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> Count;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> SizeOfNext;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> Next;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumSourceLink **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumSourceLink**, int> Clone;
    }
}
