// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWebWizardExtension.xml' path='doc/member[@name="IWebWizardExtension"]/*' />
[Guid("0E6B3F66-98D1-48C0-A222-FBDE74E2FBC5")]
[NativeTypeName("struct IWebWizardExtension : IWizardExtension")]
[NativeInheritance("IWizardExtension")]
public unsafe partial struct IWebWizardExtension : IWebWizardExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebWizardExtension);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, Guid*, void**, int>)(lpVtbl[0]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, uint>)(lpVtbl[1]))((IWebWizardExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, uint>)(lpVtbl[2]))((IWebWizardExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWizardExtension.AddPages" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPages(HPROPSHEETPAGE* aPages, uint cPages, uint* pnPagesAdded)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, HPROPSHEETPAGE*, uint, uint*, int>)(lpVtbl[3]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), aPages, cPages, pnPagesAdded);
    }

    /// <inheritdoc cref="IWizardExtension.GetFirstPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFirstPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, HPROPSHEETPAGE*, int>)(lpVtbl[4]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), phpage);
    }

    /// <inheritdoc cref="IWizardExtension.GetLastPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLastPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, HPROPSHEETPAGE*, int>)(lpVtbl[5]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), phpage);
    }

    /// <include file='IWebWizardExtension.xml' path='doc/member[@name="IWebWizardExtension.SetInitialURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetInitialURL([NativeTypeName("LPCWSTR")] char* pszURL)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, char*, int>)(lpVtbl[6]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), pszURL);
    }

    /// <include file='IWebWizardExtension.xml' path='doc/member[@name="IWebWizardExtension.SetErrorURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetErrorURL([NativeTypeName("LPCWSTR")] char* pszErrorURL)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebWizardExtension*, char*, int>)(lpVtbl[7]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), pszErrorURL);
    }

    public interface Interface : IWizardExtension.Interface
    {
        [VtblIndex(6)]
        HRESULT SetInitialURL([NativeTypeName("LPCWSTR")] char* pszURL);

        [VtblIndex(7)]
        HRESULT SetErrorURL([NativeTypeName("LPCWSTR")] char* pszErrorURL);
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

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HPROPSHEETPAGE*, uint, uint*, int> AddPages;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HPROPSHEETPAGE*, int> GetFirstPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HPROPSHEETPAGE*, int> GetLastPage;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetInitialURL;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetErrorURL;
    }
}
