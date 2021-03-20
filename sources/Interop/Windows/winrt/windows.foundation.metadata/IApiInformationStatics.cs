// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.metadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("997439FE-F681-4A11-B416-C13A47E8BA36")]
    [NativeTypeName("struct IApiInformationStatics : IInspectable")]
    public unsafe partial struct IApiInformationStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApiInformationStatics*, uint>)(lpVtbl[1]))((IApiInformationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApiInformationStatics*, uint>)(lpVtbl[2]))((IApiInformationStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr*, int>)(lpVtbl[4]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsTypePresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, byte*, int>)(lpVtbl[6]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsMethodPresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr methodName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[7]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, methodName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsMethodPresentWithArity([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr methodName, [NativeTypeName("UINT32")] uint inputParameterCount, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, uint, byte*, int>)(lpVtbl[8]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, methodName, inputParameterCount, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEventPresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr eventName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[9]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, eventName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPropertyPresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr propertyName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[10]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsReadOnlyPropertyPresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr propertyName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[11]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsWriteablePropertyPresent([NativeTypeName("HSTRING")] IntPtr typeName, [NativeTypeName("HSTRING")] IntPtr propertyName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[12]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), typeName, propertyName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEnumNamedValuePresent([NativeTypeName("HSTRING")] IntPtr enumTypeName, [NativeTypeName("HSTRING")] IntPtr valueName, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, IntPtr, byte*, int>)(lpVtbl[13]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), enumTypeName, valueName, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsApiContractPresentByMajor([NativeTypeName("HSTRING")] IntPtr contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, ushort, byte*, int>)(lpVtbl[14]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), contractName, majorVersion, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsApiContractPresentByMajorAndMinor([NativeTypeName("HSTRING")] IntPtr contractName, [NativeTypeName("UINT16")] ushort majorVersion, [NativeTypeName("UINT16")] ushort minorVersion, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IApiInformationStatics*, IntPtr, ushort, ushort, byte*, int>)(lpVtbl[15]))((IApiInformationStatics*)Unsafe.AsPointer(ref this), contractName, majorVersion, minorVersion, result);
        }
    }
}
