// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("130F5136-EC43-4F61-89C7-9801A36D2E95")]
    [NativeTypeName("struct IVisualTreeService2 : IVisualTreeService")]
    [NativeInheritance("IVisualTreeService")]
    public unsafe partial struct IVisualTreeService2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint>)(lpVtbl[1]))((IVisualTreeService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint>)(lpVtbl[2]))((IVisualTreeService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCount, ppEnums);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, InstanceHandle* pInstanceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ushort*, ushort*, InstanceHandle*, int>)(lpVtbl[6]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPropertyValuesChain(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetProperty(InstanceHandle instanceHandle, InstanceHandle value, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[8]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ClearProperty(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint, int>)(lpVtbl[9]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCollectionCount(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint*, int>)(lpVtbl[10]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCollectionElements(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddChild(InstanceHandle parent, InstanceHandle child, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[12]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent, child, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint, int>)(lpVtbl[13]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ClearChildren(InstanceHandle parent)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, int>)(lpVtbl[14]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPropertyIndex(InstanceHandle @object, [NativeTypeName("LPCWSTR")] ushort* propertyName, [NativeTypeName("unsigned int *")] uint* pPropertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, ushort*, uint*, int>)(lpVtbl[15]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), @object, propertyName, pPropertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetProperty(InstanceHandle @object, [NativeTypeName("unsigned int")] uint propertyIndex, InstanceHandle* pValue)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, uint, InstanceHandle*, int>)(lpVtbl[16]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), @object, propertyIndex, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ReplaceResource(InstanceHandle resourceDictionary, InstanceHandle key, InstanceHandle newValue)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, InstanceHandle, InstanceHandle, int>)(lpVtbl[17]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), resourceDictionary, key, newValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT RenderTargetBitmap(InstanceHandle handle, RenderTargetBitmapOptions options, [NativeTypeName("unsigned int")] uint maxPixelWidth, [NativeTypeName("unsigned int")] uint maxPixelHeight, IBitmapData** ppBitmapData)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, InstanceHandle, RenderTargetBitmapOptions, uint, uint, IBitmapData**, int>)(lpVtbl[18]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), handle, options, maxPixelWidth, maxPixelHeight, ppBitmapData);
        }
    }
}
