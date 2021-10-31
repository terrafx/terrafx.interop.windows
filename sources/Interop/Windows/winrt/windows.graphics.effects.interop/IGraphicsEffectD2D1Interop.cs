// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2FC57384-A068-44D7-A331-30982FCF7177")]
    [NativeTypeName("struct IGraphicsEffectD2D1Interop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGraphicsEffectD2D1Interop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, Guid*, void**, int>)(lpVtbl[0]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[1]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[2]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEffectId(Guid* id)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, Guid*, int>)(lpVtbl[3]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetNamedPropertyMapping([NativeTypeName("LPCWSTR")] ushort* name, uint* index, [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")] GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, ushort*, uint*, GRAPHICS_EFFECT_PROPERTY_MAPPING*, int>)(lpVtbl[4]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), name, index, mapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyCount(uint* count)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[5]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetProperty(uint index, [NativeTypeName("Windows::Foundation::IPropertyValue **")] void** value)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint, void**, int>)(lpVtbl[6]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSource(uint index, [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffectSource **")] void** source)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint, void**, int>)(lpVtbl[7]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSourceCount(uint* count)
        {
            return ((delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[8]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
        }
    }
}
