// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6B3F66-98D1-48C0-A222-FBDE74E2FBC5")]
    [NativeTypeName("struct IWebWizardExtension : IWizardExtension")]
    [NativeInheritance("IWizardExtension")]
    public unsafe partial struct IWebWizardExtension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, Guid*, void**, int>)(lpVtbl[0]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebWizardExtension*, uint>)(lpVtbl[1]))((IWebWizardExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebWizardExtension*, uint>)(lpVtbl[2]))((IWebWizardExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPages(HPROPSHEETPAGE* aPages, uint cPages, uint* pnPagesAdded)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, HPROPSHEETPAGE*, uint, uint*, int>)(lpVtbl[3]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), aPages, cPages, pnPagesAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFirstPage(HPROPSHEETPAGE* phpage)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, HPROPSHEETPAGE*, int>)(lpVtbl[4]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetLastPage(HPROPSHEETPAGE* phpage)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, HPROPSHEETPAGE*, int>)(lpVtbl[5]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetInitialURL([NativeTypeName("LPCWSTR")] ushort* pszURL)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, ushort*, int>)(lpVtbl[6]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), pszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetErrorURL([NativeTypeName("LPCWSTR")] ushort* pszErrorURL)
        {
            return ((delegate* unmanaged<IWebWizardExtension*, ushort*, int>)(lpVtbl[7]))((IWebWizardExtension*)Unsafe.AsPointer(ref this), pszErrorURL);
        }
    }
}
