// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("2FC57384-A068-44D7-A331-30982FCF7177")]
    [NativeTypeName("struct IGraphicsEffectD2D1Interop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGraphicsEffectD2D1Interop : IGraphicsEffectD2D1Interop.Interface
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

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetEffectId(Guid* id);

            [VtblIndex(4)]
            HRESULT GetNamedPropertyMapping([NativeTypeName("LPCWSTR")] ushort* name, uint* index, [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")] GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping);

            [VtblIndex(5)]
            HRESULT GetPropertyCount(uint* count);

            [VtblIndex(6)]
            HRESULT GetProperty(uint index, [NativeTypeName("Windows::Foundation::IPropertyValue **")] void** value);

            [VtblIndex(7)]
            HRESULT GetSource(uint index, [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffectSource **")] void** source);

            [VtblIndex(8)]
            HRESULT GetSourceCount(uint* count);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, Guid*, int> GetEffectId;

            [NativeTypeName("HRESULT (LPCWSTR, UINT *, ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, ushort*, uint*, GRAPHICS_EFFECT_PROPERTY_MAPPING*, int> GetNamedPropertyMapping;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint*, int> GetPropertyCount;

            [NativeTypeName("HRESULT (UINT, Windows::Foundation::IPropertyValue **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint, void**, int> GetProperty;

            [NativeTypeName("HRESULT (UINT, ABI::Windows::Graphics::Effects::IGraphicsEffectSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint, void**, int> GetSource;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphicsEffectD2D1Interop*, uint*, int> GetSourceCount;
        }
    }
}
