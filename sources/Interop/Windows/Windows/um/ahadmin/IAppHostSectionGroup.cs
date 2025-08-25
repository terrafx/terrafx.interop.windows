// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup"]/*' />
[Guid("0DD8A158-EBE6-4008-A1D9-B7ECC8F1104B")]
[NativeTypeName("struct IAppHostSectionGroup : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostSectionGroup : IAppHostSectionGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostSectionGroup);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, uint>)(lpVtbl[1]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, uint>)(lpVtbl[2]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcSectionGroup)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, uint*, int>)(lpVtbl[3]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), pcSectionGroup);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT varIndex, IAppHostSectionGroup** ppSectionGroup)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, VARIANT, IAppHostSectionGroup**, int>)(lpVtbl[4]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), varIndex, ppSectionGroup);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.get_Sections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Sections(IAppHostSectionDefinitionCollection** ppSections)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, IAppHostSectionDefinitionCollection**, int>)(lpVtbl[5]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), ppSections);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.AddSectionGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSectionGroup([NativeTypeName("BSTR")] char* bstrSectionGroupName, IAppHostSectionGroup** ppSectionGroup)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, char*, IAppHostSectionGroup**, int>)(lpVtbl[6]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), bstrSectionGroupName, ppSectionGroup);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.DeleteSectionGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteSectionGroup(VARIANT varIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, VARIANT, int>)(lpVtbl[7]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), varIndex);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, char**, int>)(lpVtbl[8]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, char**, int>)(lpVtbl[9]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), pbstrType);
    }

    /// <include file='IAppHostSectionGroup.xml' path='doc/member[@name="IAppHostSectionGroup.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Type([NativeTypeName("BSTR")] char* bstrType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostSectionGroup*, char*, int>)(lpVtbl[10]))((IAppHostSectionGroup*)Unsafe.AsPointer(ref this), bstrType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("ULONG *")] uint* pcSectionGroup);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT varIndex, IAppHostSectionGroup** ppSectionGroup);

        [VtblIndex(5)]
        HRESULT get_Sections(IAppHostSectionDefinitionCollection** ppSections);

        [VtblIndex(6)]
        HRESULT AddSectionGroup([NativeTypeName("BSTR")] char* bstrSectionGroupName, IAppHostSectionGroup** ppSectionGroup);

        [VtblIndex(7)]
        HRESULT DeleteSectionGroup(VARIANT varIndex);

        [VtblIndex(8)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(9)]
        HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType);

        [VtblIndex(10)]
        HRESULT put_Type([NativeTypeName("BSTR")] char* bstrType);
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

        [NativeTypeName("HRESULT (VARIANT, IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostSectionGroup**, int> get_Item;

        [NativeTypeName("HRESULT (IAppHostSectionDefinitionCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostSectionDefinitionCollection**, int> get_Sections;

        [NativeTypeName("HRESULT (BSTR, IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostSectionGroup**, int> AddSectionGroup;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> DeleteSectionGroup;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_Type;
    }
}
