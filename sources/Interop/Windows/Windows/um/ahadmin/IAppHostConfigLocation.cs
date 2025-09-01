// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation"]/*' />
[Guid("370AF178-7758-4DAD-8146-7391F6E18585")]
[NativeTypeName("struct IAppHostConfigLocation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigLocation : IAppHostConfigLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostConfigLocation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, uint>)(lpVtbl[1]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, uint>)(lpVtbl[2]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] char** pbstrLocationPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, char**, int>)(lpVtbl[3]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), pbstrLocationPath);
    }

    /// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, uint*, int>)(lpVtbl[4]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostElement** ppSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, VARIANT, IAppHostElement**, int>)(lpVtbl[5]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), cIndex, ppSection);
    }

    /// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation.AddConfigSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddConfigSection([NativeTypeName("BSTR")] char* bstrSectionName, IAppHostElement** ppAdminElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, char*, IAppHostElement**, int>)(lpVtbl[6]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), bstrSectionName, ppAdminElement);
    }

    /// <include file='IAppHostConfigLocation.xml' path='doc/member[@name="IAppHostConfigLocation.DeleteConfigSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteConfigSection(VARIANT cIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocation*, VARIANT, int>)(lpVtbl[7]))((IAppHostConfigLocation*)Unsafe.AsPointer(ref this), cIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Path([NativeTypeName("BSTR *")] char** pbstrLocationPath);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(5)]
        HRESULT get_Item(VARIANT cIndex, IAppHostElement** ppSection);

        [VtblIndex(6)]
        HRESULT AddConfigSection([NativeTypeName("BSTR")] char* bstrSectionName, IAppHostElement** ppAdminElement);

        [VtblIndex(7)]
        HRESULT DeleteConfigSection(VARIANT cIndex);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Path;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostElement**, int> get_Item;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostElement**, int> AddConfigSection;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> DeleteConfigSection;
    }
}
