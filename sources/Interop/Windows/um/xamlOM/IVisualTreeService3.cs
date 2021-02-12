// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E79C6E0-85A0-4BE8-B41A-655CF1FD19BD")]
    [NativeTypeName("struct IVisualTreeService3 : IVisualTreeService2")]
    public unsafe partial struct IVisualTreeService3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeService3*, uint>)(lpVtbl[1]))((IVisualTreeService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeService3*, uint>)(lpVtbl[2]))((IVisualTreeService3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseVisualTreeChange([NativeTypeName("IVisualTreeServiceCallback *")] IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseVisualTreeChange([NativeTypeName("IVisualTreeServiceCallback *")] IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnums([NativeTypeName("unsigned int *")] uint* pCount, [NativeTypeName("EnumType **")] EnumType** ppEnums)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCount, ppEnums);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, [NativeTypeName("InstanceHandle *")] ulong* pInstanceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ushort*, ushort*, ulong*, int>)(lpVtbl[6]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValuesChain([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, [NativeTypeName("PropertyChainSource **")] PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, [NativeTypeName("PropertyChainValue **")] PropertyChainValue** ppPropertyValues)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("InstanceHandle")] ulong value, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ulong, uint, int>)(lpVtbl[8]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint, int>)(lpVtbl[9]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionCount([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint*, int>)(lpVtbl[10]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionElements([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, [NativeTypeName("CollectionElementValue **")] CollectionElementValue** ppElementValues)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("InstanceHandle")] ulong child, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ulong, uint, int>)(lpVtbl[12]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent, child, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint, int>)(lpVtbl[13]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearChildren([NativeTypeName("InstanceHandle")] ulong parent)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, int>)(lpVtbl[14]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyIndex([NativeTypeName("InstanceHandle")] ulong @object, [NativeTypeName("LPCWSTR")] ushort* propertyName, [NativeTypeName("unsigned int *")] uint* pPropertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ushort*, uint*, int>)(lpVtbl[15]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), @object, propertyName, pPropertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("InstanceHandle")] ulong @object, [NativeTypeName("unsigned int")] uint propertyIndex, [NativeTypeName("InstanceHandle *")] ulong* pValue)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, uint, ulong*, int>)(lpVtbl[16]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), @object, propertyIndex, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceResource([NativeTypeName("InstanceHandle")] ulong resourceDictionary, [NativeTypeName("InstanceHandle")] ulong key, [NativeTypeName("InstanceHandle")] ulong newValue)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ulong, ulong, int>)(lpVtbl[17]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), resourceDictionary, key, newValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderTargetBitmap([NativeTypeName("InstanceHandle")] ulong handle, RenderTargetBitmapOptions options, [NativeTypeName("unsigned int")] uint maxPixelWidth, [NativeTypeName("unsigned int")] uint maxPixelHeight, [NativeTypeName("IBitmapData **")] IBitmapData** ppBitmapData)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, RenderTargetBitmapOptions, uint, uint, IBitmapData**, int>)(lpVtbl[18]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), handle, options, maxPixelWidth, maxPixelHeight, ppBitmapData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResolveResource([NativeTypeName("InstanceHandle")] ulong resourceContext, [NativeTypeName("LPCWSTR")] ushort* resourceName, ResourceType resourceType, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ushort*, ResourceType, uint, int>)(lpVtbl[19]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), resourceContext, resourceName, resourceType, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDictionaryItem([NativeTypeName("InstanceHandle")] ulong dictionaryHandle, [NativeTypeName("LPCWSTR")] ushort* resourceName, [NativeTypeName("BOOL")] int resourceIsImplicitStyle, [NativeTypeName("InstanceHandle *")] ulong* resourceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ushort*, int, ulong*, int>)(lpVtbl[20]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceName, resourceIsImplicitStyle, resourceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDictionaryItem([NativeTypeName("InstanceHandle")] ulong dictionaryHandle, [NativeTypeName("InstanceHandle")] ulong resourceKey, [NativeTypeName("InstanceHandle")] ulong resourceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ulong, ulong, int>)(lpVtbl[21]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceKey, resourceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveDictionaryItem([NativeTypeName("InstanceHandle")] ulong dictionaryHandle, [NativeTypeName("InstanceHandle")] ulong resourceKey)
        {
            return ((delegate* unmanaged<IVisualTreeService3*, ulong, ulong, int>)(lpVtbl[22]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceKey);
        }
    }
}
