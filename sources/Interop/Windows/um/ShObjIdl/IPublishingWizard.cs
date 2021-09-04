// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA9198BB-CCEC-472D-BEED-19A4F6733F7A")]
    [NativeTypeName("struct IPublishingWizard : IWizardExtension")]
    public unsafe partial struct IPublishingWizard
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPublishingWizard*, Guid*, void**, int>)(lpVtbl[0]))((IPublishingWizard*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPublishingWizard*, uint>)(lpVtbl[1]))((IPublishingWizard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPublishingWizard*, uint>)(lpVtbl[2]))((IPublishingWizard*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPages([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* aPages, [NativeTypeName("UINT")] uint cPages, [NativeTypeName("UINT *")] uint* pnPagesAdded)
        {
            return ((delegate* unmanaged<IPublishingWizard*, IntPtr*, uint, uint*, int>)(lpVtbl[3]))((IPublishingWizard*)Unsafe.AsPointer(ref this), aPages, cPages, pnPagesAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFirstPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IPublishingWizard*, IntPtr*, int>)(lpVtbl[4]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastPage([NativeTypeName("HPROPSHEETPAGE *")] IntPtr* phpage)
        {
            return ((delegate* unmanaged<IPublishingWizard*, IntPtr*, int>)(lpVtbl[5]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phpage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IDataObject* pdo, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* pszServiceScope)
        {
            return ((delegate* unmanaged<IPublishingWizard*, IDataObject*, uint, ushort*, int>)(lpVtbl[6]))((IPublishingWizard*)Unsafe.AsPointer(ref this), pdo, dwOptions, pszServiceScope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransferManifest([NativeTypeName("HRESULT *")] int* phrFromTransfer, IXMLDOMDocument** pdocManifest)
        {
            return ((delegate* unmanaged<IPublishingWizard*, int*, IXMLDOMDocument**, int>)(lpVtbl[7]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phrFromTransfer, pdocManifest);
        }
    }
}
