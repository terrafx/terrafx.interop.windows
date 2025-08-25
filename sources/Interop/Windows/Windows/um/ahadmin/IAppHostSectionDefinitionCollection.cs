// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostSectionDefinitionCollection.xml' path='doc/member[@name="IAppHostSectionDefinitionCollection"]/*' />
[Guid("B7D381EE-8860-47A1-8AF4-1F33B2B1F325")]
[NativeTypeName("struct IAppHostSectionDefinitionCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionDefinitionCollection : IAppHostSectionDefinitionCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostSectionDefinitionCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, uint>)(lpVtbl[1]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, uint>)(lpVtbl[2]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostSectionDefinitionCollection.xml' path='doc/member[@name="IAppHostSectionDefinitionCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, uint*, int>)(lpVtbl[3]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostSectionDefinitionCollection.xml' path='doc/member[@name="IAppHostSectionDefinitionCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT varIndex, IAppHostSectionDefinition** ppConfigSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, VARIANT, IAppHostSectionDefinition**, int>)(lpVtbl[4]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this), varIndex, ppConfigSection);
    }

    /// <include file='IAppHostSectionDefinitionCollection.xml' path='doc/member[@name="IAppHostSectionDefinitionCollection.AddSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddSection([NativeTypeName("BSTR")] char* bstrSectionName, IAppHostSectionDefinition** ppConfigSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, char*, IAppHostSectionDefinition**, int>)(lpVtbl[5]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this), bstrSectionName, ppConfigSection);
    }

    /// <include file='IAppHostSectionDefinitionCollection.xml' path='doc/member[@name="IAppHostSectionDefinitionCollection.DeleteSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteSection(VARIANT varIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionDefinitionCollection*, VARIANT, int>)(lpVtbl[6]))((IAppHostSectionDefinitionCollection*)Unsafe.AsPointer(ref this), varIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT varIndex, IAppHostSectionDefinition** ppConfigSection);

        [VtblIndex(5)]
        HRESULT AddSection([NativeTypeName("BSTR")] char* bstrSectionName, IAppHostSectionDefinition** ppConfigSection);

        [VtblIndex(6)]
        HRESULT DeleteSection(VARIANT varIndex);
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostSectionDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostSectionDefinition**, int> get_Item;

        [NativeTypeName("HRESULT (BSTR, IAppHostSectionDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostSectionDefinition**, int> AddSection;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> DeleteSection;
    }
}
