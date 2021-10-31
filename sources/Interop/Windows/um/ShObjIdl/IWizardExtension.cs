// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C02EA696-86CC-491E-9B23-74394A0444A8")]
    [NativeTypeName("struct IWizardExtension : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWizardExtension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWizardExtension*, Guid*, void**, int>)(lpVtbl[0]))((IWizardExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWizardExtension*, uint>)(lpVtbl[1]))((IWizardExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWizardExtension*, uint>)(lpVtbl[2]))((IWizardExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPages([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* aPages, [NativeTypeName("UINT")] uint cPages, [NativeTypeName("UINT *")] uint* pnPagesAdded)
        {
            return ((delegate* unmanaged<IWizardExtension*, IntPtr*, uint, uint*, int>)(lpVtbl[3]))((IWizardExtension*)Unsafe.AsPointer(ref this), aPages, cPages, pnPagesAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFirstPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IWizardExtension*, IntPtr*, int>)(lpVtbl[4]))((IWizardExtension*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetLastPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IWizardExtension*, IntPtr*, int>)(lpVtbl[5]))((IWizardExtension*)Unsafe.AsPointer(ref this), phpage);
        }
    }
}
