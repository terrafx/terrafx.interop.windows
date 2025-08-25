// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem"]/*' />
[Guid("CA724E8A-C3E6-442B-88A4-6FB0DB8035A3")]
[NativeTypeName("struct IPropertySystem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertySystem : IPropertySystem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPropertySystem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySystem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, uint>)(lpVtbl[1]))((IPropertySystem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, uint>)(lpVtbl[2]))((IPropertySystem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.GetPropertyDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, PROPERTYKEY*, Guid*, void**, int>)(lpVtbl[3]))((IPropertySystem*)Unsafe.AsPointer(ref this), propkey, riid, ppv);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.GetPropertyDescriptionByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] char* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, char*, Guid*, void**, int>)(lpVtbl[4]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszCanonicalName, riid, ppv);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.GetPropertyDescriptionListFromString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] char* pszPropList, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, char*, Guid*, void**, int>)(lpVtbl[5]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPropList, riid, ppv);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.EnumeratePropertyDescriptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, PROPDESC_ENUMFILTER, Guid*, void**, int>)(lpVtbl[6]))((IPropertySystem*)Unsafe.AsPointer(ref this), filterOn, riid, ppv);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.FormatForDisplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR")] char* pszText, [NativeTypeName("DWORD")] uint cchText)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, char*, uint, int>)(lpVtbl[7]))((IPropertySystem*)Unsafe.AsPointer(ref this), key, propvar, pdff, pszText, cchText);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.FormatForDisplayAlloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] char** ppszDisplay)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, char**, int>)(lpVtbl[8]))((IPropertySystem*)Unsafe.AsPointer(ref this), key, propvar, pdff, ppszDisplay);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.RegisterPropertySchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterPropertySchema([NativeTypeName("LPCWSTR")] char* pszPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, char*, int>)(lpVtbl[9]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.UnregisterPropertySchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UnregisterPropertySchema([NativeTypeName("LPCWSTR")] char* pszPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, char*, int>)(lpVtbl[10]))((IPropertySystem*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <include file='IPropertySystem.xml' path='doc/member[@name="IPropertySystem.RefreshPropertySchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RefreshPropertySchema()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySystem*, int>)(lpVtbl[11]))((IPropertySystem*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(4)]
        HRESULT GetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] char* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT GetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] char* pszPropList, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(6)]
        HRESULT EnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(7)]
        HRESULT FormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR")] char* pszText, [NativeTypeName("DWORD")] uint cchText);

        [VtblIndex(8)]
        HRESULT FormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] char** ppszDisplay);

        [VtblIndex(9)]
        HRESULT RegisterPropertySchema([NativeTypeName("LPCWSTR")] char* pszPath);

        [VtblIndex(10)]
        HRESULT UnregisterPropertySchema([NativeTypeName("LPCWSTR")] char* pszPath);

        [VtblIndex(11)]
        HRESULT RefreshPropertySchema();
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

        [NativeTypeName("HRESULT (const PROPERTYKEY &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPERTYKEY*, Guid*, void**, int> GetPropertyDescription;

        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, void**, int> GetPropertyDescriptionByName;

        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, void**, int> GetPropertyDescriptionListFromString;

        [NativeTypeName("HRESULT (PROPDESC_ENUMFILTER, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPDESC_ENUMFILTER, Guid*, void**, int> EnumeratePropertyDescriptions;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, char*, uint, int> FormatForDisplay;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPERTYKEY*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, char**, int> FormatForDisplayAlloc;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> RegisterPropertySchema;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> UnregisterPropertySchema;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RefreshPropertySchema;
    }
}
