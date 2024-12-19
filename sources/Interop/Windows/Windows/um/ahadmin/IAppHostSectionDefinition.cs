// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition"]/*' />
[Guid("C5C04795-321C-4014-8FD6-D44658799393")]
[NativeTypeName("struct IAppHostSectionDefinition : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionDefinition : IAppHostSectionDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostSectionDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, uint>)(lpVtbl[1]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, uint>)(lpVtbl[2]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char**, int>)(lpVtbl[3]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char**, int>)(lpVtbl[4]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pbstrType);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Type([NativeTypeName("BSTR")] char* bstrType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char*, int>)(lpVtbl[5]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), bstrType);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_OverrideModeDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OverrideModeDefault([NativeTypeName("BSTR *")] char** pbstrOverrideModeDefault)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char**, int>)(lpVtbl[6]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pbstrOverrideModeDefault);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.put_OverrideModeDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OverrideModeDefault([NativeTypeName("BSTR")] char* bstrOverrideModeDefault)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char*, int>)(lpVtbl[7]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), bstrOverrideModeDefault);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_AllowDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowDefinition([NativeTypeName("BSTR *")] char** pbstrAllowDefinition)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char**, int>)(lpVtbl[8]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pbstrAllowDefinition);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.put_AllowDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AllowDefinition([NativeTypeName("BSTR")] char* bstrAllowDefinition)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char*, int>)(lpVtbl[9]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), bstrAllowDefinition);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_AllowLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllowLocation([NativeTypeName("BSTR *")] char** pbstrAllowLocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char**, int>)(lpVtbl[10]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pbstrAllowLocation);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.put_AllowLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AllowLocation([NativeTypeName("BSTR")] char* bstrAllowLocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, char*, int>)(lpVtbl[11]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), bstrAllowLocation);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.get_RequirePermission"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequirePermission([NativeTypeName("VARIANT_BOOL *")] short* pfRequirePermission)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, short*, int>)(lpVtbl[12]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pfRequirePermission);
    }

    /// <include file='IAppHostSectionDefinition.xml' path='doc/member[@name="IAppHostSectionDefinition.put_RequirePermission"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequirePermission([NativeTypeName("VARIANT_BOOL")] short pfRequirePermission)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinition*, short, int>)(lpVtbl[13]))((IAppHostSectionDefinition*)Unsafe.AsPointer(ref this), pfRequirePermission);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType);

        [VtblIndex(5)]
        HRESULT put_Type([NativeTypeName("BSTR")] char* bstrType);

        [VtblIndex(6)]
        HRESULT get_OverrideModeDefault([NativeTypeName("BSTR *")] char** pbstrOverrideModeDefault);

        [VtblIndex(7)]
        HRESULT put_OverrideModeDefault([NativeTypeName("BSTR")] char* bstrOverrideModeDefault);

        [VtblIndex(8)]
        HRESULT get_AllowDefinition([NativeTypeName("BSTR *")] char** pbstrAllowDefinition);

        [VtblIndex(9)]
        HRESULT put_AllowDefinition([NativeTypeName("BSTR")] char* bstrAllowDefinition);

        [VtblIndex(10)]
        HRESULT get_AllowLocation([NativeTypeName("BSTR *")] char** pbstrAllowLocation);

        [VtblIndex(11)]
        HRESULT put_AllowLocation([NativeTypeName("BSTR")] char* bstrAllowLocation);

        [VtblIndex(12)]
        HRESULT get_RequirePermission([NativeTypeName("VARIANT_BOOL *")] short* pfRequirePermission);

        [VtblIndex(13)]
        HRESULT put_RequirePermission([NativeTypeName("VARIANT_BOOL")] short pfRequirePermission);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_Type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_OverrideModeDefault;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_OverrideModeDefault;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_AllowDefinition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_AllowDefinition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_AllowLocation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_AllowLocation;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_RequirePermission;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> put_RequirePermission;
    }
}
