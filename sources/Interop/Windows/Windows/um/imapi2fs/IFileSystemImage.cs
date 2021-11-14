// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("2C941FE1-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IFileSystemImage : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IFileSystemImage : IFileSystemImage.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemImage*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint>)(lpVtbl[1]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint>)(lpVtbl[2]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint*, int>)(lpVtbl[3]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSystemImage*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSystemImage*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSystemImage*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSystemImage*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Root(IFsiDirectoryItem** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IFsiDirectoryItem**, int>)(lpVtbl[7]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[8]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[9]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[10]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[11]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetMaxMediaBlocksFromDevice(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int>)(lpVtbl[12]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[13]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[14]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, int>)(lpVtbl[15]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[16]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_BootImageOptions(IBootOptions** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IBootOptions**, int>)(lpVtbl[17]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_BootImageOptions(IBootOptions* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IBootOptions*, int>)(lpVtbl[18]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_FileCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[19]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[20]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[21]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, int>)(lpVtbl[22]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[23]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[24]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[25]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[26]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[27]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_FileSystemsToCreate(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[28]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_FileSystemsToCreate(FsiFileSystems newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int>)(lpVtbl[29]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_FileSystemsSupported(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[30]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_UDFRevision([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[31]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[32]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_UDFRevisionsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[33]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT ChooseImageDefaults(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int>)(lpVtbl[34]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IMAPI_MEDIA_PHYSICAL_TYPE, int>)(lpVtbl[35]))((IFileSystemImage*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[36]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[37]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[38]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT CreateResultImage(IFileSystemImageResult** resultStream)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IFileSystemImageResult**, int>)(lpVtbl[39]))((IFileSystemImage*)Unsafe.AsPointer(ref this), resultStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, FsiItemType*, int>)(lpVtbl[40]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fullPath, itemType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[41]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT IdentifyFileSystemsOnDisc(IDiscRecorder2* discRecorder, FsiFileSystems* fileSystems)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, FsiFileSystems*, int>)(lpVtbl[42]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder, fileSystems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT GetDefaultFileSystemForImport(FsiFileSystems fileSystems, FsiFileSystems* importDefault)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, FsiFileSystems*, int>)(lpVtbl[43]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fileSystems, importDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT ImportFileSystem(FsiFileSystems* importedFileSystem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[44]))((IFileSystemImage*)Unsafe.AsPointer(ref this), importedFileSystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int>)(lpVtbl[45]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fileSystemToUse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[46]))((IFileSystemImage*)Unsafe.AsPointer(ref this), changePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT LockInChangePoint()
        {
            return ((delegate* unmanaged<IFileSystemImage*, int>)(lpVtbl[47]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, IFsiDirectoryItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, IFsiDirectoryItem**, int>)(lpVtbl[48]))((IFileSystemImage*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, IFsiFileItem**, int>)(lpVtbl[49]))((IFileSystemImage*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[50]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[51]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[52]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[53]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[54]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_MultisessionInterfaces(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[55]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT put_MultisessionInterfaces(SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY*, int>)(lpVtbl[56]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_Root(IFsiDirectoryItem** pVal);

            [VtblIndex(8)]
            HRESULT get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(9)]
            HRESULT put_SessionStartBlock([NativeTypeName("LONG")] int newVal);

            [VtblIndex(10)]
            HRESULT get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(11)]
            HRESULT put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal);

            [VtblIndex(12)]
            HRESULT SetMaxMediaBlocksFromDevice(IDiscRecorder2* discRecorder);

            [VtblIndex(13)]
            HRESULT get_UsedBlocks([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(14)]
            HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(15)]
            HRESULT put_VolumeName([NativeTypeName("BSTR")] ushort* newVal);

            [VtblIndex(16)]
            HRESULT get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(17)]
            HRESULT get_BootImageOptions(IBootOptions** pVal);

            [VtblIndex(18)]
            HRESULT put_BootImageOptions(IBootOptions* newVal);

            [VtblIndex(19)]
            HRESULT get_FileCount([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(20)]
            HRESULT get_DirectoryCount([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(21)]
            HRESULT get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(22)]
            HRESULT put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal);

            [VtblIndex(23)]
            HRESULT get_ChangePoint([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(24)]
            HRESULT get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal);

            [VtblIndex(25)]
            HRESULT put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal);

            [VtblIndex(26)]
            HRESULT get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal);

            [VtblIndex(27)]
            HRESULT put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal);

            [VtblIndex(28)]
            HRESULT get_FileSystemsToCreate(FsiFileSystems* pVal);

            [VtblIndex(29)]
            HRESULT put_FileSystemsToCreate(FsiFileSystems newVal);

            [VtblIndex(30)]
            HRESULT get_FileSystemsSupported(FsiFileSystems* pVal);

            [VtblIndex(31)]
            HRESULT put_UDFRevision([NativeTypeName("LONG")] int newVal);

            [VtblIndex(32)]
            HRESULT get_UDFRevision([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(33)]
            HRESULT get_UDFRevisionsSupported(SAFEARRAY** pVal);

            [VtblIndex(34)]
            HRESULT ChooseImageDefaults(IDiscRecorder2* discRecorder);

            [VtblIndex(35)]
            HRESULT ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value);

            [VtblIndex(36)]
            HRESULT put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal);

            [VtblIndex(37)]
            HRESULT get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal);

            [VtblIndex(38)]
            HRESULT get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal);

            [VtblIndex(39)]
            HRESULT CreateResultImage(IFileSystemImageResult** resultStream);

            [VtblIndex(40)]
            HRESULT Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType);

            [VtblIndex(41)]
            HRESULT CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier);

            [VtblIndex(42)]
            HRESULT IdentifyFileSystemsOnDisc(IDiscRecorder2* discRecorder, FsiFileSystems* fileSystems);

            [VtblIndex(43)]
            HRESULT GetDefaultFileSystemForImport(FsiFileSystems fileSystems, FsiFileSystems* importDefault);

            [VtblIndex(44)]
            HRESULT ImportFileSystem(FsiFileSystems* importedFileSystem);

            [VtblIndex(45)]
            HRESULT ImportSpecificFileSystem(FsiFileSystems fileSystemToUse);

            [VtblIndex(46)]
            HRESULT RollbackToChangePoint([NativeTypeName("LONG")] int changePoint);

            [VtblIndex(47)]
            HRESULT LockInChangePoint();

            [VtblIndex(48)]
            HRESULT CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, IFsiDirectoryItem** newItem);

            [VtblIndex(49)]
            HRESULT CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem** newItem);

            [VtblIndex(50)]
            HRESULT get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(51)]
            HRESULT get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(52)]
            HRESULT get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal);

            [VtblIndex(53)]
            HRESULT get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal);

            [VtblIndex(54)]
            HRESULT put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal);

            [VtblIndex(55)]
            HRESULT get_MultisessionInterfaces(SAFEARRAY** pVal);

            [VtblIndex(56)]
            HRESULT put_MultisessionInterfaces(SAFEARRAY* newVal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IFsiDirectoryItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IFsiDirectoryItem**, int> get_Root;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_SessionStartBlock;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, int> put_SessionStartBlock;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_FreeMediaBlocks;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, int> put_FreeMediaBlocks;

            [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int> SetMaxMediaBlocksFromDevice;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_UsedBlocks;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_VolumeName;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort*, int> put_VolumeName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_ImportedVolumeName;

            [NativeTypeName("HRESULT (IBootOptions **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IBootOptions**, int> get_BootImageOptions;

            [NativeTypeName("HRESULT (IBootOptions *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IBootOptions*, int> put_BootImageOptions;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_FileCount;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_DirectoryCount;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_WorkingDirectory;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort*, int> put_WorkingDirectory;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_ChangePoint;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short*, int> get_StrictFileSystemCompliance;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short, int> put_StrictFileSystemCompliance;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short*, int> get_UseRestrictedCharacterSet;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short, int> put_UseRestrictedCharacterSet;

            [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int> get_FileSystemsToCreate;

            [NativeTypeName("HRESULT (FsiFileSystems) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int> put_FileSystemsToCreate;

            [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int> get_FileSystemsSupported;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, int> put_UDFRevision;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_UDFRevision;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int> get_UDFRevisionsSupported;

            [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int> ChooseImageDefaults;

            [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IMAPI_MEDIA_PHYSICAL_TYPE, int> ChooseImageDefaultsForMediaType;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, int> put_ISO9660InterchangeLevel;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int*, int> get_ISO9660InterchangeLevel;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int> get_ISO9660InterchangeLevelsSupported;

            [NativeTypeName("HRESULT (IFileSystemImageResult **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IFileSystemImageResult**, int> CreateResultImage;

            [NativeTypeName("HRESULT (BSTR, FsiItemType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort*, FsiItemType*, int> Exists;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> CalculateDiscIdentifier;

            [NativeTypeName("HRESULT (IDiscRecorder2 *, FsiFileSystems *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, FsiFileSystems*, int> IdentifyFileSystemsOnDisc;

            [NativeTypeName("HRESULT (FsiFileSystems, FsiFileSystems *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems, FsiFileSystems*, int> GetDefaultFileSystemForImport;

            [NativeTypeName("HRESULT (FsiFileSystems *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int> ImportFileSystem;

            [NativeTypeName("HRESULT (FsiFileSystems) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int> ImportSpecificFileSystem;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int, int> RollbackToChangePoint;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, int> LockInChangePoint;

            [NativeTypeName("HRESULT (BSTR, IFsiDirectoryItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort*, IFsiDirectoryItem**, int> CreateDirectoryItem;

            [NativeTypeName("HRESULT (BSTR, IFsiFileItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort*, IFsiFileItem**, int> CreateFileItem;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_VolumeNameUDF;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_VolumeNameJoliet;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, ushort**, int> get_VolumeNameISO9660;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short*, int> get_StageFiles;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, short, int> put_StageFiles;

            [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int> get_MultisessionInterfaces;

            [NativeTypeName("HRESULT (SAFEARRAY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileSystemImage*, SAFEARRAY*, int> put_MultisessionInterfaces;
        }
    }
}
