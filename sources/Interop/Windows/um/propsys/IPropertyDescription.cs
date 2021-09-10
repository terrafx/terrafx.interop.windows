// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F79D558-3E96-4549-A1D1-7D75D2288814")]
    [NativeTypeName("struct IPropertyDescription : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyDescription
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyDescription*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint>)(lpVtbl[1]))((IPropertyDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint>)(lpVtbl[2]))((IPropertyDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[4]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort*, int>)(lpVtbl[5]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pvartype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[6]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[7]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescription*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint*, int>)(lpVtbl[10]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint*, int>)(lpVtbl[12]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescription*)Unsafe.AsPointer(ref this), prdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription(PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescription*)Unsafe.AsPointer(ref this), psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged<IPropertyDescription*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescription*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescription*)Unsafe.AsPointer(ref this), paggtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType(PROPDESC_CONDITION_TYPE* pcontype, CONDITION_OPERATION* popDefault)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescription*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescription*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue(PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar);
        }
    }
}
