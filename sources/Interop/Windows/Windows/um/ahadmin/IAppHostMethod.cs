// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostMethod.xml' path='doc/member[@name="IAppHostMethod"]/*' />
[Guid("7883CA1C-1112-4447-84C3-52FBEB38069D")]
[NativeTypeName("struct IAppHostMethod : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethod : IAppHostMethod.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMethod));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostMethod*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, uint>)(lpVtbl[1]))((IAppHostMethod*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, uint>)(lpVtbl[2]))((IAppHostMethod*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMethod.xml' path='doc/member[@name="IAppHostMethod.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, char**, int>)(lpVtbl[3]))((IAppHostMethod*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostMethod.xml' path='doc/member[@name="IAppHostMethod.get_Schema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Schema(IAppHostMethodSchema** ppMethodSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, IAppHostMethodSchema**, int>)(lpVtbl[4]))((IAppHostMethod*)Unsafe.AsPointer(ref this), ppMethodSchema);
    }

    /// <include file='IAppHostMethod.xml' path='doc/member[@name="IAppHostMethod.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateInstance(IAppHostMethodInstance** ppMethodInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethod*, IAppHostMethodInstance**, int>)(lpVtbl[5]))((IAppHostMethod*)Unsafe.AsPointer(ref this), ppMethodInstance);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Schema(IAppHostMethodSchema** ppMethodSchema);

        [VtblIndex(5)]
        HRESULT CreateInstance(IAppHostMethodInstance** ppMethodInstance);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (IAppHostMethodSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostMethodSchema**, int> get_Schema;

        [NativeTypeName("HRESULT (IAppHostMethodInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostMethodInstance**, int> CreateInstance;
    }
}
