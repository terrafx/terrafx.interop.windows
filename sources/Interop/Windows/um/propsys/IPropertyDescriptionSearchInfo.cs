// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("078F91BD-29A2-440F-924E-46A291524520")]
    [NativeTypeName("struct IPropertyDescriptionSearchInfo : IPropertyDescription")]
    public unsafe partial struct IPropertyDescriptionSearchInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, uint>)(lpVtbl[1]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, uint>)(lpVtbl[2]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyKey([NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, ushort**, int>)(lpVtbl[4]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, ushort*, int>)(lpVtbl[5]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pvartype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, ushort**, int>)(lpVtbl[6]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, ushort**, int>)(lpVtbl[7]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags(PROPDESC_TYPE_FLAGS mask, [NativeTypeName("PROPDESC_TYPE_FLAGS *")] PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags([NativeTypeName("PROPDESC_VIEW_FLAGS *")] PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultColumnWidth([NativeTypeName("UINT *")] uint* pcxChars)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, uint*, int>)(lpVtbl[10]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayType([NativeTypeName("PROPDESC_DISPLAYTYPE *")] PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, uint*, int>)(lpVtbl[12]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupingRange([NativeTypeName("PROPDESC_GROUPING_RANGE *")] PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescriptionType([NativeTypeName("PROPDESC_RELATIVEDESCRIPTION_TYPE *")] PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), prdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescription([NativeTypeName("PROPDESC_SORTDESCRIPTION *")] PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortDescriptionLabel([NativeTypeName("BOOL")] int fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, int, ushort**, int>)(lpVtbl[17]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAggregationType([NativeTypeName("PROPDESC_AGGREGATION_TYPE *")] PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), paggtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType([NativeTypeName("PROPDESC_CONDITION_TYPE *")] PROPDESC_CONDITION_TYPE* pcontype, [NativeTypeName("CONDITION_OPERATION *")] CONDITION_OPERATION* popDefault)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CoerceToCanonicalValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSearchInfoFlags([NativeTypeName("PROPDESC_SEARCHINFO_FLAGS *")] PROPDESC_SEARCHINFO_FLAGS* ppdsiFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_SEARCHINFO_FLAGS*, int>)(lpVtbl[24]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppdsiFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnIndexType([NativeTypeName("PROPDESC_COLUMNINDEX_TYPE *")] PROPDESC_COLUMNINDEX_TYPE* ppdciType)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, PROPDESC_COLUMNINDEX_TYPE*, int>)(lpVtbl[25]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppdciType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProjectionString([NativeTypeName("LPWSTR *")] ushort** ppszProjection)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, ushort**, int>)(lpVtbl[26]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), ppszProjection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxSize([NativeTypeName("UINT *")] uint* pcbMaxSize)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyDescriptionSearchInfo*, uint*, int>)(lpVtbl[27]))((IPropertyDescriptionSearchInfo*)Unsafe.AsPointer(ref this), pcbMaxSize);
        }
    }
}
