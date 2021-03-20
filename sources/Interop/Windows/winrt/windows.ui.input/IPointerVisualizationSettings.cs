// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4D1E6461-84F7-499D-BD91-2A36E2B7AAA2")]
    [NativeTypeName("struct IPointerVisualizationSettings : IInspectable")]
    public unsafe partial struct IPointerVisualizationSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, uint>)(lpVtbl[1]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, uint>)(lpVtbl[2]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, IntPtr*, int>)(lpVtbl[4]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, TrustLevel*, int>)(lpVtbl[5]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsContactFeedbackEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, byte, int>)(lpVtbl[6]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsContactFeedbackEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, byte*, int>)(lpVtbl[7]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, byte, int>)(lpVtbl[8]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettings*, byte*, int>)(lpVtbl[9]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
        }
    }
}
