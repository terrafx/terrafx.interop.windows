// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("987A573E-46EE-4E89-96AB-DDF7F8FDC98C")]
    [NativeTypeName("struct IShellUIHelper6 : IShellUIHelper5")]
    [NativeInheritance("IShellUIHelper5")]
    public unsafe partial struct IShellUIHelper6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, Guid*, void**, int>)(lpVtbl[0]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, uint>)(lpVtbl[1]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, uint>)(lpVtbl[2]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, uint*, int>)(lpVtbl[3]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ResetFirstBootMode()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[7]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ResetSafeMode()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[8]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshOfflineDesktop()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[9]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, Title);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int AddChannel([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[11]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int AddDesktopComponent([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Type, VARIANT* Left, VARIANT* Top, VARIANT* Width, VARIANT* Height)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, Type, Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int IsSubscribed([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, short*, int>)(lpVtbl[13]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int NavigateAndFind([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* strQuery, VARIANT* varTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[14]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, strQuery, varTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ImportExportFavorites([NativeTypeName("VARIANT_BOOL")] short fImport, [NativeTypeName("BSTR")] ushort* strImpExpPath)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, ushort*, int>)(lpVtbl[15]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fImport, strImpExpPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int AutoCompleteSaveForm(VARIANT* Form)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT*, int>)(lpVtbl[16]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), Form);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int AutoScan([NativeTypeName("BSTR")] ushort* strSearch, [NativeTypeName("BSTR")] ushort* strFailureUrl, VARIANT* pvarTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[17]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), strSearch, strFailureUrl, pvarTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int AutoCompleteAttach(VARIANT* Reserved)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT*, int>)(lpVtbl[18]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), Reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int ShowBrowserUI([NativeTypeName("BSTR")] ushort* bstrName, VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, VARIANT*, VARIANT*, int>)(lpVtbl[19]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrName, pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[20]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int RunOnceShown()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[21]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SkipRunOnce()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[22]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CustomizeSettings([NativeTypeName("VARIANT_BOOL")] short fSQM, [NativeTypeName("VARIANT_BOOL")] short fPhishing, [NativeTypeName("BSTR")] ushort* bstrLocale)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, short, ushort*, int>)(lpVtbl[23]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fSQM, fPhishing, bstrLocale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[24]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[25]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort**, int>)(lpVtbl[26]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pbstrUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SkipTabsWelcome()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[27]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int DiagnoseConnection()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[28]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[29]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int IsSearchProviderInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, uint*, int>)(lpVtbl[30]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[31]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfMigrated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort**, int>)(lpVtbl[32]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[33]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fComplete);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[34]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort**, int>)(lpVtbl[35]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pbstrUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int AddService([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[36]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int IsServiceInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Verb, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, uint*, int>)(lpVtbl[37]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, Verb, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[38]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int AddToFavoritesBar([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Title, VARIANT* Type)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[39]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, Title, Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int BuildNewTabPage()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[40]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[41]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[42]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int ContentDiscoveryReset()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[43]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[44]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[45]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int NavigateToSuggestedSites([NativeTypeName("BSTR")] ushort* bstrRelativeUrl)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[46]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrRelativeUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int ShowTabsHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[47]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int ShowInPrivateHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[48]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[49]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfSiteMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeShowThumbBar()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[50]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeAddThumbBarButton([NativeTypeName("BSTR")] ushort* bstrIconURL, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarButtonID)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[51]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrIconURL, bstrTooltip, pvarButtonID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeUpdateThumbBarButton(VARIANT ButtonID, [NativeTypeName("VARIANT_BOOL")] short fEnabled, [NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT, short, short, int>)(lpVtbl[52]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), ButtonID, fEnabled, fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeSetIconOverlay([NativeTypeName("BSTR")] ushort* IconUrl, VARIANT* pvarDescription)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, VARIANT*, int>)(lpVtbl[53]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), IconUrl, pvarDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeClearIconOverlay()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[54]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int msAddSiteMode()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[55]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeCreateJumpList([NativeTypeName("BSTR")] ushort* bstrHeader)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[56]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeAddJumpListItem([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrActionUri, [NativeTypeName("BSTR")] ushort* bstrIconUri, VARIANT* pvarWindowType)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[57]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeClearJumpList()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[58]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeShowJumpList()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[59]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeAddButtonStyle(VARIANT uiButtonID, [NativeTypeName("BSTR")] ushort* bstrIconUrl, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarStyleID)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT, ushort*, ushort*, VARIANT*, int>)(lpVtbl[60]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT, VARIANT, int>)(lpVtbl[61]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), uiButtonID, uiStyleID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeActivate()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[62]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int msIsSiteModeFirstRun([NativeTypeName("VARIANT_BOOL")] short fPreserveState, VARIANT* puiFirstRun)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, VARIANT*, int>)(lpVtbl[63]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fPreserveState, puiFirstRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int msAddTrackingProtectionList([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* bstrFilterName)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, int>)(lpVtbl[64]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), URL, bstrFilterName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[65]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short*, int>)(lpVtbl[66]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int msProvisionNetworks([NativeTypeName("BSTR")] ushort* bstrProvisioningXml, VARIANT* puiResult)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, VARIANT*, int>)(lpVtbl[67]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrProvisioningXml, puiResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int msReportSafeUrl()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[68]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeRefreshBadge()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[69]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int msSiteModeClearBadge()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[70]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int msDiagnoseConnectionUILess()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[71]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int msLaunchNetworkClientHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[72]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[73]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int msStopPeriodicTileUpdate()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[74]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int msStartPeriodicTileUpdate(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[75]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int msStartPeriodicTileUpdateBatch(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[76]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int msClearTile()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[77]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int msEnableTileNotificationQueue([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[78]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int msPinnedSiteState(VARIANT* pvarSiteState)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, VARIANT*, int>)(lpVtbl[79]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pvarSiteState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int msEnableTileNotificationQueueForSquare150x150([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[80]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int msEnableTileNotificationQueueForWide310x150([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[81]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int msEnableTileNotificationQueueForSquare310x310([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, short, int>)(lpVtbl[82]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int msScheduledTileNotification([NativeTypeName("BSTR")] ushort* bstrNotificationXml, [NativeTypeName("BSTR")] ushort* bstrNotificationId, [NativeTypeName("BSTR")] ushort* bstrNotificationTag, VARIANT startTime, VARIANT expirationTime)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, ushort*, ushort*, VARIANT, VARIANT, int>)(lpVtbl[83]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrNotificationXml, bstrNotificationId, bstrNotificationTag, startTime, expirationTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int msRemoveScheduledTileNotification([NativeTypeName("BSTR")] ushort* bstrNotificationId)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, int>)(lpVtbl[84]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), bstrNotificationId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int msStartPeriodicBadgeUpdate([NativeTypeName("BSTR")] ushort* pollingUri, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper6*, ushort*, VARIANT, VARIANT, int>)(lpVtbl[85]))((IShellUIHelper6*)Unsafe.AsPointer(ref this), pollingUri, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int msStopPeriodicBadgeUpdate()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[86]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int msLaunchInternetOptions()
        {
            return ((delegate* unmanaged<IShellUIHelper6*, int>)(lpVtbl[87]))((IShellUIHelper6*)Unsafe.AsPointer(ref this));
        }
    }
}
