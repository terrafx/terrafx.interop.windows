// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellUIHelper9.xml' path='doc/member[@name="IShellUIHelper9"]/*' />
[Guid("6CDF73B0-7F2F-451F-BC0F-63E0F3284E54")]
[NativeTypeName("struct IShellUIHelper9 : IShellUIHelper8")]
[NativeInheritance("IShellUIHelper8")]
public unsafe partial struct IShellUIHelper9 : IShellUIHelper9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, Guid*, void**, int>)(lpVtbl[0]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, uint>)(lpVtbl[1]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, uint>)(lpVtbl[2]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, uint*, int>)(lpVtbl[3]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IShellUIHelper.ResetFirstBootMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetFirstBootMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[7]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper.ResetSafeMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[8]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper.RefreshOfflineDesktop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[9]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper.AddFavorite" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] char* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, VARIANT*, int>)(lpVtbl[10]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, Title);
    }

    /// <inheritdoc cref="IShellUIHelper.AddChannel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] char* URL)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[11]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref="IShellUIHelper.AddDesktopComponent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddDesktopComponent([NativeTypeName("BSTR")] char* URL, [NativeTypeName("BSTR")] char* Type, VARIANT* Left, VARIANT* Top, VARIANT* Width, VARIANT* Height)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, Type, Left, Top, Width, Height);
    }

    /// <inheritdoc cref="IShellUIHelper.IsSubscribed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsSubscribed([NativeTypeName("BSTR")] char* URL, [NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short*, int>)(lpVtbl[13]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, pBool);
    }

    /// <inheritdoc cref="IShellUIHelper.NavigateAndFind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT NavigateAndFind([NativeTypeName("BSTR")] char* URL, [NativeTypeName("BSTR")] char* strQuery, VARIANT* varTargetFrame)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, VARIANT*, int>)(lpVtbl[14]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, strQuery, varTargetFrame);
    }

    /// <inheritdoc cref="IShellUIHelper.ImportExportFavorites" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites([NativeTypeName("VARIANT_BOOL")] short fImport, [NativeTypeName("BSTR")] char* strImpExpPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, char*, int>)(lpVtbl[15]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fImport, strImpExpPath);
    }

    /// <inheritdoc cref="IShellUIHelper.AutoCompleteSaveForm" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT*, int>)(lpVtbl[16]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), Form);
    }

    /// <inheritdoc cref="IShellUIHelper.AutoScan" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AutoScan([NativeTypeName("BSTR")] char* strSearch, [NativeTypeName("BSTR")] char* strFailureUrl, VARIANT* pvarTargetFrame)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, VARIANT*, int>)(lpVtbl[17]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), strSearch, strFailureUrl, pvarTargetFrame);
    }

    /// <inheritdoc cref="IShellUIHelper.AutoCompleteAttach" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT*, int>)(lpVtbl[18]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), Reserved);
    }

    /// <inheritdoc cref="IShellUIHelper.ShowBrowserUI" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowBrowserUI([NativeTypeName("BSTR")] char* bstrName, VARIANT* pvarIn, VARIANT* pvarOut)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, VARIANT*, VARIANT*, int>)(lpVtbl[19]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrName, pvarIn, pvarOut);
    }

    /// <inheritdoc cref="IShellUIHelper2.AddSearchProvider" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddSearchProvider([NativeTypeName("BSTR")] char* URL)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[20]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref="IShellUIHelper2.RunOnceShown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RunOnceShown()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[21]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper2.SkipRunOnce" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SkipRunOnce()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[22]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper2.CustomizeSettings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CustomizeSettings([NativeTypeName("VARIANT_BOOL")] short fSQM, [NativeTypeName("VARIANT_BOOL")] short fPhishing, [NativeTypeName("BSTR")] char* bstrLocale)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, short, char*, int>)(lpVtbl[23]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fSQM, fPhishing, bstrLocale);
    }

    /// <inheritdoc cref="IShellUIHelper2.SqmEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[24]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper2.PhishingEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[25]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper2.BrandImageUri" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT BrandImageUri([NativeTypeName("BSTR *")] char** pbstrUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[26]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrUri);
    }

    /// <inheritdoc cref="IShellUIHelper2.SkipTabsWelcome" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SkipTabsWelcome()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[27]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper2.DiagnoseConnection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DiagnoseConnection()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[28]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper2.CustomizeClearType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[29]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fSet);
    }

    /// <inheritdoc cref="IShellUIHelper2.IsSearchProviderInstalled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT IsSearchProviderInstalled([NativeTypeName("BSTR")] char* URL, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, uint*, int>)(lpVtbl[30]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, pdwResult);
    }

    /// <inheritdoc cref="IShellUIHelper2.IsSearchMigrated" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[31]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfMigrated);
    }

    /// <inheritdoc cref="IShellUIHelper2.DefaultSearchProvider" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[32]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <inheritdoc cref="IShellUIHelper2.RunOnceRequiredSettingsComplete" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[33]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fComplete);
    }

    /// <inheritdoc cref="IShellUIHelper2.RunOnceHasShown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[34]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfShown);
    }

    /// <inheritdoc cref="IShellUIHelper2.SearchGuideUrl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] char** pbstrUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[35]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrUrl);
    }

    /// <inheritdoc cref="IShellUIHelper3.AddService" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT AddService([NativeTypeName("BSTR")] char* URL)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[36]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL);
    }

    /// <inheritdoc cref="IShellUIHelper3.IsServiceInstalled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsServiceInstalled([NativeTypeName("BSTR")] char* URL, [NativeTypeName("BSTR")] char* Verb, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, uint*, int>)(lpVtbl[37]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, Verb, pdwResult);
    }

    /// <inheritdoc cref="IShellUIHelper3.InPrivateFilteringEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[38]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper3.AddToFavoritesBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT AddToFavoritesBar([NativeTypeName("BSTR")] char* URL, [NativeTypeName("BSTR")] char* Title, VARIANT* Type)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, VARIANT*, int>)(lpVtbl[39]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, Title, Type);
    }

    /// <inheritdoc cref="IShellUIHelper3.BuildNewTabPage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT BuildNewTabPage()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[40]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper3.SetRecentlyClosedVisible" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[41]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fVisible);
    }

    /// <inheritdoc cref="IShellUIHelper3.SetActivitiesVisible" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[42]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fVisible);
    }

    /// <inheritdoc cref="IShellUIHelper3.ContentDiscoveryReset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ContentDiscoveryReset()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[43]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper3.IsSuggestedSitesEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[44]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper3.EnableSuggestedSites" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[45]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fEnable);
    }

    /// <inheritdoc cref="IShellUIHelper3.NavigateToSuggestedSites" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT NavigateToSuggestedSites([NativeTypeName("BSTR")] char* bstrRelativeUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[46]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrRelativeUrl);
    }

    /// <inheritdoc cref="IShellUIHelper3.ShowTabsHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT ShowTabsHelp()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[47]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper3.ShowInPrivateHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT ShowInPrivateHelp()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[48]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msIsSiteMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[49]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfSiteMode);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeShowThumbBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT msSiteModeShowThumbBar()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[50]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeAddThumbBarButton" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT msSiteModeAddThumbBarButton([NativeTypeName("BSTR")] char* bstrIconURL, [NativeTypeName("BSTR")] char* bstrTooltip, VARIANT* pvarButtonID)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, VARIANT*, int>)(lpVtbl[51]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrIconURL, bstrTooltip, pvarButtonID);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeUpdateThumbBarButton" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT msSiteModeUpdateThumbBarButton(VARIANT ButtonID, [NativeTypeName("VARIANT_BOOL")] short fEnabled, [NativeTypeName("VARIANT_BOOL")] short fVisible)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT, short, short, int>)(lpVtbl[52]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), ButtonID, fEnabled, fVisible);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeSetIconOverlay" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT msSiteModeSetIconOverlay([NativeTypeName("BSTR")] char* IconUrl, VARIANT* pvarDescription)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, VARIANT*, int>)(lpVtbl[53]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), IconUrl, pvarDescription);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeClearIconOverlay" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT msSiteModeClearIconOverlay()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[54]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msAddSiteMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT msAddSiteMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[55]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeCreateJumpList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT msSiteModeCreateJumpList([NativeTypeName("BSTR")] char* bstrHeader)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[56]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrHeader);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeAddJumpListItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT msSiteModeAddJumpListItem([NativeTypeName("BSTR")] char* bstrName, [NativeTypeName("BSTR")] char* bstrActionUri, [NativeTypeName("BSTR")] char* bstrIconUri, VARIANT* pvarWindowType)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, char*, VARIANT*, int>)(lpVtbl[57]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeClearJumpList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT msSiteModeClearJumpList()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[58]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeShowJumpList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT msSiteModeShowJumpList()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[59]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeAddButtonStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT msSiteModeAddButtonStyle(VARIANT uiButtonID, [NativeTypeName("BSTR")] char* bstrIconUrl, [NativeTypeName("BSTR")] char* bstrTooltip, VARIANT* pvarStyleID)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT, char*, char*, VARIANT*, int>)(lpVtbl[60]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeShowButtonStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT, VARIANT, int>)(lpVtbl[61]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), uiButtonID, uiStyleID);
    }

    /// <inheritdoc cref="IShellUIHelper4.msSiteModeActivate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT msSiteModeActivate()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[62]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper4.msIsSiteModeFirstRun" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT msIsSiteModeFirstRun([NativeTypeName("VARIANT_BOOL")] short fPreserveState, VARIANT* puiFirstRun)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, VARIANT*, int>)(lpVtbl[63]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fPreserveState, puiFirstRun);
    }

    /// <inheritdoc cref="IShellUIHelper4.msAddTrackingProtectionList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT msAddTrackingProtectionList([NativeTypeName("BSTR")] char* URL, [NativeTypeName("BSTR")] char* bstrFilterName)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, int>)(lpVtbl[64]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), URL, bstrFilterName);
    }

    /// <inheritdoc cref="IShellUIHelper4.msTrackingProtectionEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[65]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper4.msActiveXFilteringEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short*, int>)(lpVtbl[66]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    /// <inheritdoc cref="IShellUIHelper5.msProvisionNetworks" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT msProvisionNetworks([NativeTypeName("BSTR")] char* bstrProvisioningXml, VARIANT* puiResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, VARIANT*, int>)(lpVtbl[67]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrProvisioningXml, puiResult);
    }

    /// <inheritdoc cref="IShellUIHelper5.msReportSafeUrl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT msReportSafeUrl()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[68]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper5.msSiteModeRefreshBadge" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT msSiteModeRefreshBadge()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[69]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper5.msSiteModeClearBadge" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT msSiteModeClearBadge()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[70]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper5.msDiagnoseConnectionUILess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT msDiagnoseConnectionUILess()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[71]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper5.msLaunchNetworkClientHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT msLaunchNetworkClientHelp()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[72]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper5.msChangeDefaultBrowser" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[73]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fChange);
    }

    /// <inheritdoc cref="IShellUIHelper6.msStopPeriodicTileUpdate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT msStopPeriodicTileUpdate()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[74]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper6.msStartPeriodicTileUpdate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT msStartPeriodicTileUpdate(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[75]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
    }

    /// <inheritdoc cref="IShellUIHelper6.msStartPeriodicTileUpdateBatch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT msStartPeriodicTileUpdateBatch(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[76]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
    }

    /// <inheritdoc cref="IShellUIHelper6.msClearTile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT msClearTile()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[77]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper6.msEnableTileNotificationQueue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT msEnableTileNotificationQueue([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[78]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fChange);
    }

    /// <inheritdoc cref="IShellUIHelper6.msPinnedSiteState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT msPinnedSiteState(VARIANT* pvarSiteState)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, VARIANT*, int>)(lpVtbl[79]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pvarSiteState);
    }

    /// <inheritdoc cref="IShellUIHelper6.msEnableTileNotificationQueueForSquare150x150" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT msEnableTileNotificationQueueForSquare150x150([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[80]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fChange);
    }

    /// <inheritdoc cref="IShellUIHelper6.msEnableTileNotificationQueueForWide310x150" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT msEnableTileNotificationQueueForWide310x150([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[81]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fChange);
    }

    /// <inheritdoc cref="IShellUIHelper6.msEnableTileNotificationQueueForSquare310x310" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT msEnableTileNotificationQueueForSquare310x310([NativeTypeName("VARIANT_BOOL")] short fChange)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, short, int>)(lpVtbl[82]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), fChange);
    }

    /// <inheritdoc cref="IShellUIHelper6.msScheduledTileNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT msScheduledTileNotification([NativeTypeName("BSTR")] char* bstrNotificationXml, [NativeTypeName("BSTR")] char* bstrNotificationId, [NativeTypeName("BSTR")] char* bstrNotificationTag, VARIANT startTime, VARIANT expirationTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, char*, char*, VARIANT, VARIANT, int>)(lpVtbl[83]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrNotificationXml, bstrNotificationId, bstrNotificationTag, startTime, expirationTime);
    }

    /// <inheritdoc cref="IShellUIHelper6.msRemoveScheduledTileNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT msRemoveScheduledTileNotification([NativeTypeName("BSTR")] char* bstrNotificationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[84]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrNotificationId);
    }

    /// <inheritdoc cref="IShellUIHelper6.msStartPeriodicBadgeUpdate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT msStartPeriodicBadgeUpdate([NativeTypeName("BSTR")] char* pollingUri, VARIANT startTime, VARIANT uiUpdateRecurrence)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, VARIANT, VARIANT, int>)(lpVtbl[85]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pollingUri, startTime, uiUpdateRecurrence);
    }

    /// <inheritdoc cref="IShellUIHelper6.msStopPeriodicBadgeUpdate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT msStopPeriodicBadgeUpdate()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[86]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper6.msLaunchInternetOptions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT msLaunchInternetOptions()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[87]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper7.SetExperimentalFlag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT SetExperimentalFlag([NativeTypeName("BSTR")] char* bstrFlagString, [NativeTypeName("VARIANT_BOOL")] short vfFlag)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short, int>)(lpVtbl[88]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrFlagString, vfFlag);
    }

    /// <inheritdoc cref="IShellUIHelper7.GetExperimentalFlag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT GetExperimentalFlag([NativeTypeName("BSTR")] char* bstrFlagString, [NativeTypeName("VARIANT_BOOL *")] short* vfFlag)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short*, int>)(lpVtbl[89]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrFlagString, vfFlag);
    }

    /// <inheritdoc cref="IShellUIHelper7.SetExperimentalValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT SetExperimentalValue([NativeTypeName("BSTR")] char* bstrValueString, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, uint, int>)(lpVtbl[90]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrValueString, dwValue);
    }

    /// <inheritdoc cref="IShellUIHelper7.GetExperimentalValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT GetExperimentalValue([NativeTypeName("BSTR")] char* bstrValueString, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, uint*, int>)(lpVtbl[91]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrValueString, pdwValue);
    }

    /// <inheritdoc cref="IShellUIHelper7.ResetAllExperimentalFlagsAndValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT ResetAllExperimentalFlagsAndValues()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[92]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper7.GetNeedIEAutoLaunchFlag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT GetNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] char* bstrUrl, [NativeTypeName("VARIANT_BOOL *")] short* flag)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short*, int>)(lpVtbl[93]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrUrl, flag);
    }

    /// <inheritdoc cref="IShellUIHelper7.SetNeedIEAutoLaunchFlag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT SetNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] char* bstrUrl, [NativeTypeName("VARIANT_BOOL")] short flag)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short, int>)(lpVtbl[94]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrUrl, flag);
    }

    /// <inheritdoc cref="IShellUIHelper7.HasNeedIEAutoLaunchFlag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT HasNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] char* bstrUrl, [NativeTypeName("VARIANT_BOOL *")] short* exists)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short*, int>)(lpVtbl[95]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrUrl, exists);
    }

    /// <inheritdoc cref="IShellUIHelper7.LaunchIE" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT LaunchIE([NativeTypeName("BSTR")] char* bstrUrl, [NativeTypeName("VARIANT_BOOL")] short automated)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, short, int>)(lpVtbl[96]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrUrl, automated);
    }

    /// <inheritdoc cref="IShellUIHelper8.GetCVListData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT GetCVListData([NativeTypeName("BSTR *")] char** pbstrResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[97]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrResult);
    }

    /// <inheritdoc cref="IShellUIHelper8.GetCVListLocalData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT GetCVListLocalData([NativeTypeName("BSTR *")] char** pbstrResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[98]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrResult);
    }

    /// <inheritdoc cref="IShellUIHelper8.GetEMIEListData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT GetEMIEListData([NativeTypeName("BSTR *")] char** pbstrResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[99]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrResult);
    }

    /// <inheritdoc cref="IShellUIHelper8.GetEMIEListLocalData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT GetEMIEListLocalData([NativeTypeName("BSTR *")] char** pbstrResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char**, int>)(lpVtbl[100]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pbstrResult);
    }

    /// <inheritdoc cref="IShellUIHelper8.OpenFavoritesPane" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT OpenFavoritesPane()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[101]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper8.OpenFavoritesSettings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT OpenFavoritesSettings()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, int>)(lpVtbl[102]))((IShellUIHelper9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellUIHelper8.LaunchInHVSI" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT LaunchInHVSI([NativeTypeName("BSTR")] char* bstrUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, char*, int>)(lpVtbl[103]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), bstrUrl);
    }

    /// <include file='IShellUIHelper9.xml' path='doc/member[@name="IShellUIHelper9.GetOSSku"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT GetOSSku([NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellUIHelper9*, uint*, int>)(lpVtbl[104]))((IShellUIHelper9*)Unsafe.AsPointer(ref this), pdwResult);
    }

    public interface Interface : IShellUIHelper8.Interface
    {
        [VtblIndex(104)]
        HRESULT GetOSSku([NativeTypeName("DWORD *")] uint* pdwResult);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ResetFirstBootMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ResetSafeMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RefreshOfflineDesktop;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> AddFavorite;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> AddChannel;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int> AddDesktopComponent;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> IsSubscribed;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT*, int> NavigateAndFind;

        [NativeTypeName("HRESULT (VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, char*, int> ImportExportFavorites;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> AutoCompleteSaveForm;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT*, int> AutoScan;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> AutoCompleteAttach;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, VARIANT*, int> ShowBrowserUI;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> AddSearchProvider;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RunOnceShown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SkipRunOnce;

        [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, short, char*, int> CustomizeSettings;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> SqmEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> PhishingEnabled;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> BrandImageUri;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SkipTabsWelcome;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DiagnoseConnection;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> CustomizeClearType;

        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> IsSearchProviderInstalled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> IsSearchMigrated;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> DefaultSearchProvider;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> RunOnceRequiredSettingsComplete;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> RunOnceHasShown;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> SearchGuideUrl;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> AddService;

        [NativeTypeName("HRESULT (BSTR, BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, int> IsServiceInstalled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> InPrivateFilteringEnabled;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT*, int> AddToFavoritesBar;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BuildNewTabPage;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> SetRecentlyClosedVisible;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> SetActivitiesVisible;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ContentDiscoveryReset;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> IsSuggestedSitesEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> EnableSuggestedSites;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> NavigateToSuggestedSites;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowTabsHelp;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowInPrivateHelp;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> msIsSiteMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeShowThumbBar;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, VARIANT*, int> msSiteModeAddThumbBarButton;

        [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, short, short, int> msSiteModeUpdateThumbBarButton;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> msSiteModeSetIconOverlay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeClearIconOverlay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msAddSiteMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> msSiteModeCreateJumpList;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, VARIANT*, int> msSiteModeAddJumpListItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeClearJumpList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeShowJumpList;

        [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, char*, char*, VARIANT*, int> msSiteModeAddButtonStyle;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, int> msSiteModeShowButtonStyle;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeActivate;

        [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, VARIANT*, int> msIsSiteModeFirstRun;

        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> msAddTrackingProtectionList;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> msTrackingProtectionEnabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> msActiveXFilteringEnabled;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> msProvisionNetworks;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msReportSafeUrl;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeRefreshBadge;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msSiteModeClearBadge;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msDiagnoseConnectionUILess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msLaunchNetworkClientHelp;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> msChangeDefaultBrowser;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msStopPeriodicTileUpdate;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, VARIANT, int> msStartPeriodicTileUpdate;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, VARIANT, VARIANT, int> msStartPeriodicTileUpdateBatch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msClearTile;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> msEnableTileNotificationQueue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> msPinnedSiteState;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> msEnableTileNotificationQueueForSquare150x150;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> msEnableTileNotificationQueueForWide310x150;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, int> msEnableTileNotificationQueueForSquare310x310;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, VARIANT, VARIANT, int> msScheduledTileNotification;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> msRemoveScheduledTileNotification;

        [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, VARIANT, int> msStartPeriodicBadgeUpdate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msStopPeriodicBadgeUpdate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> msLaunchInternetOptions;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short, int> SetExperimentalFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> GetExperimentalFlag;

        [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetExperimentalValue;

        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetExperimentalValue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ResetAllExperimentalFlagsAndValues;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> GetNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short, int> SetNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> HasNeedIEAutoLaunchFlag;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short, int> LaunchIE;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetCVListData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetCVListLocalData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetEMIEListData;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetEMIEListLocalData;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> OpenFavoritesPane;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> OpenFavoritesSettings;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> LaunchInHVSI;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetOSSku;
    }
}
