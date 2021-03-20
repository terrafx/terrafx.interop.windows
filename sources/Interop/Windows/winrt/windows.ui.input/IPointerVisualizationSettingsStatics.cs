// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68870EDB-165B-4214-B4F3-584ECA8C8A69")]
    [NativeTypeName("struct IPointerVisualizationSettingsStatics : IInspectable")]
    public unsafe partial struct IPointerVisualizationSettingsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, uint>)(lpVtbl[1]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, uint>)(lpVtbl[2]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, IntPtr*, int>)(lpVtbl[4]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentView([NativeTypeName("ABI::Windows::UI::Input::IPointerVisualizationSettings **")] IPointerVisualizationSettings** visualizationSettings)
        {
            return ((delegate* unmanaged<IPointerVisualizationSettingsStatics*, IPointerVisualizationSettings**, int>)(lpVtbl[6]))((IPointerVisualizationSettingsStatics*)Unsafe.AsPointer(ref this), visualizationSettings);
        }
    }
}
