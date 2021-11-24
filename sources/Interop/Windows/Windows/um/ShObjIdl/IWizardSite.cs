// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("88960F5B-422F-4E7B-8013-73415381C3C3")]
[NativeTypeName("struct IWizardSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWizardSite : IWizardSite.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWizardSite*, Guid*, void**, int>)(lpVtbl[0]))((IWizardSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWizardSite*, uint>)(lpVtbl[1]))((IWizardSite*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWizardSite*, uint>)(lpVtbl[2]))((IWizardSite*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPreviousPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int>)(lpVtbl[3]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNextPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int>)(lpVtbl[4]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCancelledPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int>)(lpVtbl[5]))((IWizardSite*)Unsafe.AsPointer(ref this), phpage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPreviousPage(HPROPSHEETPAGE* phpage);

        [VtblIndex(4)]
        HRESULT GetNextPage(HPROPSHEETPAGE* phpage);

        [VtblIndex(5)]
        HRESULT GetCancelledPage(HPROPSHEETPAGE* phpage);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, uint> Release;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int> GetPreviousPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int> GetNextPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IWizardSite*, HPROPSHEETPAGE*, int> GetCancelledPage;
    }
}
