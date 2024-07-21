// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumSourceLink2.xml' path='doc/member[@name="IDiaEnumSourceLink2"]/*' />
[Guid("136D8151-ADE7-4704-AF13-324080762E8F")]
[NativeTypeName("struct IDiaEnumSourceLink2 : IDiaEnumSourceLink")]
[NativeInheritance("IDiaEnumSourceLink")]
public unsafe partial struct IDiaEnumSourceLink2 : IDiaEnumSourceLink2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSourceLink2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint>)(lpVtbl[1]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint>)(lpVtbl[2]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.Count" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint*, int>)(lpVtbl[3]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), pCnt);
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.SizeOfNext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint*, int>)(lpVtbl[4]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.Next" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Next([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, byte* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), cb, pcb, pb);
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.Skip" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("DWORD")] uint cnt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, uint, int>)(lpVtbl[6]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), cnt);
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.Reset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, int>)(lpVtbl[7]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaEnumSourceLink.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSourceLink** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, IDiaEnumSourceLink**, int>)(lpVtbl[8]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IDiaEnumSourceLink2.xml' path='doc/member[@name="IDiaEnumSourceLink2.SizeOfNext2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SizeOfNext2([NativeTypeName("ULONGLONG *")] ulong* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, ulong*, int>)(lpVtbl[9]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <include file='IDiaEnumSourceLink2.xml' path='doc/member[@name="IDiaEnumSourceLink2.Next2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Next2([NativeTypeName("ULONGLONG")] ulong cb, [NativeTypeName("ULONGLONG *")] ulong* pcb, byte* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSourceLink2*, ulong, ulong*, byte*, int>)(lpVtbl[10]))((IDiaEnumSourceLink2*)Unsafe.AsPointer(ref this), cb, pcb, pb);
    }

    public interface Interface : IDiaEnumSourceLink.Interface
    {
        [VtblIndex(9)]
        HRESULT SizeOfNext2([NativeTypeName("ULONGLONG *")] ulong* pcb);

        [VtblIndex(10)]
        HRESULT Next2([NativeTypeName("ULONGLONG")] ulong cb, [NativeTypeName("ULONGLONG *")] ulong* pcb, byte* pb);
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

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> SizeOfNext2;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong*, byte*, int> Next2;
    }
}
