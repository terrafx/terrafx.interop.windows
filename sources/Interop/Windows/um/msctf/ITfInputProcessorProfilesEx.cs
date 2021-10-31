// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("892F230F-FE00-4A41-A98E-FCD6DE0D35EF")]
    [NativeTypeName("struct ITfInputProcessorProfilesEx : ITfInputProcessorProfiles")]
    [NativeInheritance("ITfInputProcessorProfiles")]
    public unsafe partial struct ITfInputProcessorProfilesEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, uint>)(lpVtbl[1]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, uint>)(lpVtbl[2]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Register([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, int>)(lpVtbl[3]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unregister([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, int>)(lpVtbl[4]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] ushort* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort*, uint, ushort*, uint, uint, int>)(lpVtbl[5]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, int>)(lpVtbl[6]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnumInputProcessorInfo(IEnumGUID** ppEnum)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, IEnumGUID**, int>)(lpVtbl[7]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("GUID *")] Guid* pguidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, Guid*, Guid*, Guid*, int>)(lpVtbl[8]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, catid, pclsid, pguidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, Guid*, Guid*, int>)(lpVtbl[9]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, rclsid, guidProfiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ActivateLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, int>)(lpVtbl[10]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetActiveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID *")] ushort* plangid, [NativeTypeName("GUID *")] Guid* pguidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort*, Guid*, int>)(lpVtbl[11]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, plangid, pguidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetLanguageProfileDescription([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BSTR *")] ushort** pbstrProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort**, int>)(lpVtbl[12]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pbstrProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetCurrentLanguage([NativeTypeName("LANGID *")] ushort* plangid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort*, int>)(lpVtbl[13]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), plangid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ChangeCurrentLanguage([NativeTypeName("LANGID")] ushort langid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, int>)(lpVtbl[14]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetLanguageList([NativeTypeName("LANGID **")] ushort** ppLangId, [NativeTypeName("ULONG *")] uint* pulCount)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort**, uint*, int>)(lpVtbl[15]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), ppLangId, pulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EnumLanguageProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfLanguageProfiles** ppEnum)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, IEnumTfLanguageProfiles**, int>)(lpVtbl[16]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT EnableLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL fEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL, int>)(lpVtbl[17]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT IsEnabledLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL* pfEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL*, int>)(lpVtbl[18]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pfEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT EnableLanguageProfileByDefault([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL fEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL, int>)(lpVtbl[19]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hKL)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, HKL, int>)(lpVtbl[20]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetLanguageProfileDisplayName([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uResId)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort*, uint, uint, int>)(lpVtbl[21]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchFile, cchFile, uResId);
        }
    }
}
