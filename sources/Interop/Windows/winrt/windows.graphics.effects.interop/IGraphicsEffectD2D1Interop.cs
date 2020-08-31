// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2FC57384-A068-44D7-A331-30982FCF7177")]
    [NativeTypeName("struct IGraphicsEffectD2D1Interop : IUnknown")]
    public unsafe partial struct IGraphicsEffectD2D1Interop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, Guid*, void**, int>)(lpVtbl[0]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[1]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[2]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectId([NativeTypeName("GUID *")] Guid* id)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, Guid*, int>)(lpVtbl[3]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNamedPropertyMapping([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT *")] uint* index, [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")] GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, ushort*, uint*, GRAPHICS_EFFECT_PROPERTY_MAPPING*, int>)(lpVtbl[4]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), name, index, mapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyCount([NativeTypeName("UINT *")] uint* count)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[5]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("UINT")] uint index, [NativeTypeName("Windows::Foundation::IPropertyValue **")] void** value)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint, void**, int>)(lpVtbl[6]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSource([NativeTypeName("UINT")] uint index, [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffectSource **")] void** source)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint, void**, int>)(lpVtbl[7]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceCount([NativeTypeName("UINT *")] uint* count)
        {
            return ((delegate* stdcall<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[8]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
        }
    }
}
