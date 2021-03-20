// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52849F18-2F70-4236-AB40-D04DB0C7B931")]
    [NativeTypeName("struct IAppResourceGroupStateReport : IInspectable")]
    public unsafe partial struct IAppResourceGroupStateReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, uint>)(lpVtbl[1]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, uint>)(lpVtbl[2]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExecutionState([NativeTypeName("ABI::Windows::System::AppResourceGroupExecutionState *")] AppResourceGroupExecutionState* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, AppResourceGroupExecutionState*, int>)(lpVtbl[6]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EnergyQuotaState([NativeTypeName("ABI::Windows::System::AppResourceGroupEnergyQuotaState *")] AppResourceGroupEnergyQuotaState* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupStateReport*, AppResourceGroupEnergyQuotaState*, int>)(lpVtbl[7]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), value);
        }
    }
}
