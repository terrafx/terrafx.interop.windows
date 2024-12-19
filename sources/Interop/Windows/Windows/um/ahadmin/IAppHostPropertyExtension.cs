// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPropertyExtension.xml' path='doc/member[@name="IAppHostPropertyExtension"]/*' />
[Guid("88E220F3-33E8-4534-AFAC-B4A98ECCF9AE")]
[NativeTypeName("struct IAppHostPropertyExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertyExtension : IAppHostPropertyExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertyExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyExtension*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPropertyExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyExtension*, uint>)(lpVtbl[1]))((IAppHostPropertyExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyExtension*, uint>)(lpVtbl[2]))((IAppHostPropertyExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostPropertyExtension.xml' path='doc/member[@name="IAppHostPropertyExtension.ProvideGetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProvideGetProperty(IAppHostElement* pElement, IAppHostProperty* pProperty)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyExtension*, IAppHostElement*, IAppHostProperty*, int>)(lpVtbl[3]))((IAppHostPropertyExtension*)Unsafe.AsPointer(ref this), pElement, pProperty);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProvideGetProperty(IAppHostElement* pElement, IAppHostProperty* pProperty);
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

        [NativeTypeName("HRESULT (IAppHostElement *, IAppHostProperty *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElement*, IAppHostProperty*, int> ProvideGetProperty;
    }
}
