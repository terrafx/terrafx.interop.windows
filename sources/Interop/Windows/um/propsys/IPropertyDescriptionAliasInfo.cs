// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F67104FC-2AF9-46FD-B32D-243C1404F3D1")]
    [NativeTypeName("struct IPropertyDescriptionAliasInfo : IPropertyDescription")]
    public unsafe partial struct IPropertyDescriptionAliasInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, uint>)(lpVtbl[1]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, uint>)(lpVtbl[2]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[4]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, ushort*, int>)(lpVtbl[5]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pvartype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[6]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[7]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, uint*, int>)(lpVtbl[10]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, uint*, int>)(lpVtbl[12]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), prdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription(PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), paggtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType(PROPDESC_CONDITION_TYPE* pcontype, CONDITION_OPERATION* popDefault)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue(PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortByAlias([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[24]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdditionalSortByAliases([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[25]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
