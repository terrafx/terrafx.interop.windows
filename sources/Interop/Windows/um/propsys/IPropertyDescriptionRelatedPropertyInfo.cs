// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("507393F4-2A3D-4A60-B59E-D9C75716C2DD")]
    [NativeTypeName("struct IPropertyDescriptionRelatedPropertyInfo : IPropertyDescription")]
    public unsafe partial struct IPropertyDescriptionRelatedPropertyInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, uint>)(lpVtbl[1]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, uint>)(lpVtbl[2]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pkey);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int>)(lpVtbl[4]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, ushort*, int>)(lpVtbl[5]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pvartype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int>)(lpVtbl[6]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int>)(lpVtbl[7]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, [NativeTypeName("PROPDESC_TYPE_FLAGS *")] PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags([NativeTypeName("PROPDESC_VIEW_FLAGS *")] PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, uint*, int>)(lpVtbl[10]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType([NativeTypeName("PROPDESC_DISPLAYTYPE *")] PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, uint*, int>)(lpVtbl[12]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange([NativeTypeName("PROPDESC_GROUPING_RANGE *")] PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pgr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType([NativeTypeName("PROPDESC_RELATIVEDESCRIPTION_TYPE *")] PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), prdt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription([NativeTypeName("PROPDESC_SORTDESCRIPTION *")] PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), psd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType([NativeTypeName("PROPDESC_AGGREGATION_TYPE *")] PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), paggtype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConditionType([NativeTypeName("PROPDESC_CONDITION_TYPE *")] PROPDESC_CONDITION_TYPE* pcontype, [NativeTypeName("CONDITION_OPERATION *")] CONDITION_OPERATION* popDefault)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelatedProperty([NativeTypeName("LPCWSTR")] ushort* pszRelationshipName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyDescriptionRelatedPropertyInfo*, ushort*, Guid*, void**, int>)(lpVtbl[24]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pszRelationshipName, riid, ppv);
        }
    }
}
