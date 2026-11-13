// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO"]/*' />
[Guid("81BEFC5B-656D-44F1-B24C-D41D51B4DC81")]
[NativeTypeName("struct IEnumWIA_FORMAT_INFO : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumWIA_FORMAT_INFO : IEnumWIA_FORMAT_INFO.Interface, INativeGuid
{
    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEnumWIA_FORMAT_INFO);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, Guid*, void**, int>)(lpVtbl[0]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, uint>)(lpVtbl[1]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, uint>)(lpVtbl[2]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, WIA_FORMAT_INFO* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, uint, WIA_FORMAT_INFO*, uint*, int>)(lpVtbl[3]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, uint, int>)(lpVtbl[4]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, int>)(lpVtbl[5]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumWIA_FORMAT_INFO** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, IEnumWIA_FORMAT_INFO**, int>)(lpVtbl[6]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this), ppIEnum);
    }

    /// <include file='IEnumWIA_FORMAT_INFO.xml' path='doc/member[@name="IEnumWIA_FORMAT_INFO.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCount([NativeTypeName("ULONG *")] uint* pcelt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWIA_FORMAT_INFO*, uint*, int>)(lpVtbl[7]))((IEnumWIA_FORMAT_INFO*)Unsafe.AsPointer(ref this), pcelt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, WIA_FORMAT_INFO* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumWIA_FORMAT_INFO** ppIEnum);

        [VtblIndex(7)]
        HRESULT GetCount([NativeTypeName("ULONG *")] uint* pcelt);
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

        [NativeTypeName("HRESULT (ULONG, WIA_FORMAT_INFO *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, WIA_FORMAT_INFO*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumWIA_FORMAT_INFO **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWIA_FORMAT_INFO**, int> Clone;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;
    }
}
