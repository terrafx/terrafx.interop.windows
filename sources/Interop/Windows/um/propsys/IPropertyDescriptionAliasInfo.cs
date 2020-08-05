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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, uint>)(lpVtbl[1]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, uint>)(lpVtbl[2]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pkey);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[4]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, ushort*, int>)(lpVtbl[5]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pvartype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[6]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, ushort**, int>)(lpVtbl[7]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, [NativeTypeName("PROPDESC_TYPE_FLAGS *")] PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags([NativeTypeName("PROPDESC_VIEW_FLAGS *")] PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, uint*, int>)(lpVtbl[10]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType([NativeTypeName("PROPDESC_DISPLAYTYPE *")] PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, uint*, int>)(lpVtbl[12]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange([NativeTypeName("PROPDESC_GROUPING_RANGE *")] PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pgr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType([NativeTypeName("PROPDESC_RELATIVEDESCRIPTION_TYPE *")] PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), prdt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription([NativeTypeName("PROPDESC_SORTDESCRIPTION *")] PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), psd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType([NativeTypeName("PROPDESC_AGGREGATION_TYPE *")] PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), paggtype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConditionType([NativeTypeName("PROPDESC_CONDITION_TYPE *")] PROPDESC_CONDITION_TYPE* pcontype, [NativeTypeName("CONDITION_OPERATION *")] CONDITION_OPERATION* popDefault)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), propvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSortByAlias([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[24]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdditionalSortByAliases([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IPropertyDescriptionAliasInfo*, Guid*, void**, int>)(lpVtbl[25]))((IPropertyDescriptionAliasInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
