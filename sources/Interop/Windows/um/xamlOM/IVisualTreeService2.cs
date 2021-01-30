// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("130F5136-EC43-4F61-89C7-9801A36D2E95")]
    [NativeTypeName("struct IVisualTreeService2 : IVisualTreeService")]
    public unsafe partial struct IVisualTreeService2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint>)(lpVtbl[1]))((IVisualTreeService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint>)(lpVtbl[2]))((IVisualTreeService2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseVisualTreeChange([NativeTypeName("IVisualTreeServiceCallback *")] IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseVisualTreeChange([NativeTypeName("IVisualTreeServiceCallback *")] IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnums([NativeTypeName("unsigned int *")] uint* pCount, [NativeTypeName("EnumType **")] EnumType** ppEnums)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), pCount, ppEnums);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, [NativeTypeName("InstanceHandle *")] ulong* pInstanceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ushort*, ushort*, ulong*, int>)(lpVtbl[6]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValuesChain([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, [NativeTypeName("PropertyChainSource **")] PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, [NativeTypeName("PropertyChainValue **")] PropertyChainValue** ppPropertyValues)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("InstanceHandle")] ulong value, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, ulong, uint, int>)(lpVtbl[8]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint, int>)(lpVtbl[9]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionCount([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint*, int>)(lpVtbl[10]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionElements([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, [NativeTypeName("CollectionElementValue **")] CollectionElementValue** ppElementValues)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("InstanceHandle")] ulong child, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, ulong, uint, int>)(lpVtbl[12]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent, child, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint, int>)(lpVtbl[13]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearChildren([NativeTypeName("InstanceHandle")] ulong parent)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, int>)(lpVtbl[14]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyIndex([NativeTypeName("InstanceHandle")] ulong @object, [NativeTypeName("LPCWSTR")] ushort* propertyName, [NativeTypeName("unsigned int *")] uint* pPropertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, ushort*, uint*, int>)(lpVtbl[15]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), @object, propertyName, pPropertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("InstanceHandle")] ulong @object, [NativeTypeName("unsigned int")] uint propertyIndex, [NativeTypeName("InstanceHandle *")] ulong* pValue)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, uint, ulong*, int>)(lpVtbl[16]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), @object, propertyIndex, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceResource([NativeTypeName("InstanceHandle")] ulong resourceDictionary, [NativeTypeName("InstanceHandle")] ulong key, [NativeTypeName("InstanceHandle")] ulong newValue)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, ulong, ulong, int>)(lpVtbl[17]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), resourceDictionary, key, newValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderTargetBitmap([NativeTypeName("InstanceHandle")] ulong handle, RenderTargetBitmapOptions options, [NativeTypeName("unsigned int")] uint maxPixelWidth, [NativeTypeName("unsigned int")] uint maxPixelHeight, [NativeTypeName("IBitmapData **")] IBitmapData** ppBitmapData)
        {
            return ((delegate* unmanaged<IVisualTreeService2*, ulong, RenderTargetBitmapOptions, uint, uint, IBitmapData**, int>)(lpVtbl[18]))((IVisualTreeService2*)Unsafe.AsPointer(ref this), handle, options, maxPixelWidth, maxPixelHeight, ppBitmapData);
        }
    }
}
