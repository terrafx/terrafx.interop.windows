// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseOpenViewA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szQuery, [NativeTypeName("MSIHANDLE *")] uint* phView);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseOpenViewW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szQuery, [NativeTypeName("MSIHANDLE *")] uint* phView);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSIDBERROR MsiViewGetErrorA([NativeTypeName("MSIHANDLE")] uint hView, [NativeTypeName("LPSTR")] sbyte* szColumnNameBuffer, [NativeTypeName("LPDWORD")] uint* pcchBuf);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSIDBERROR MsiViewGetErrorW([NativeTypeName("MSIHANDLE")] uint hView, [NativeTypeName("LPWSTR")] ushort* szColumnNameBuffer, [NativeTypeName("LPDWORD")] uint* pcchBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiViewExecute([NativeTypeName("MSIHANDLE")] uint hView, [NativeTypeName("MSIHANDLE")] uint hRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiViewFetch([NativeTypeName("MSIHANDLE")] uint hView, [NativeTypeName("MSIHANDLE *")] uint* phRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiViewModify([NativeTypeName("MSIHANDLE")] uint hView, MSIMODIFY eModifyMode, [NativeTypeName("MSIHANDLE")] uint hRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiViewGetColumnInfo([NativeTypeName("MSIHANDLE")] uint hView, MSICOLINFO eColumnInfo, [NativeTypeName("MSIHANDLE *")] uint* phRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiViewClose([NativeTypeName("MSIHANDLE")] uint hView);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseGetPrimaryKeysA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName, [NativeTypeName("MSIHANDLE *")] uint* phRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseGetPrimaryKeysW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName, [NativeTypeName("MSIHANDLE *")] uint* phRecord);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSICONDITION MsiDatabaseIsTablePersistentA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSICONDITION MsiDatabaseIsTablePersistentW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetSummaryInformationA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szDatabasePath, [NativeTypeName("UINT")] uint uiUpdateCount, [NativeTypeName("MSIHANDLE *")] uint* phSummaryInfo);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetSummaryInformationW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szDatabasePath, [NativeTypeName("UINT")] uint uiUpdateCount, [NativeTypeName("MSIHANDLE *")] uint* phSummaryInfo);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoGetPropertyCount([NativeTypeName("MSIHANDLE")] uint hSummaryInfo, [NativeTypeName("PUINT")] uint* puiPropertyCount);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoSetPropertyA([NativeTypeName("MSIHANDLE")] uint hSummaryInfo, [NativeTypeName("UINT")] uint uiProperty, [NativeTypeName("UINT")] uint uiDataType, [NativeTypeName("INT")] int iValue, FILETIME* pftValue, [NativeTypeName("LPCSTR")] sbyte* szValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoSetPropertyW([NativeTypeName("MSIHANDLE")] uint hSummaryInfo, [NativeTypeName("UINT")] uint uiProperty, [NativeTypeName("UINT")] uint uiDataType, [NativeTypeName("INT")] int iValue, FILETIME* pftValue, [NativeTypeName("LPCWSTR")] ushort* szValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoGetPropertyA([NativeTypeName("MSIHANDLE")] uint hSummaryInfo, [NativeTypeName("UINT")] uint uiProperty, [NativeTypeName("PUINT")] uint* puiDataType, [NativeTypeName("LPINT")] int* piValue, FILETIME* pftValue, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoGetPropertyW([NativeTypeName("MSIHANDLE")] uint hSummaryInfo, [NativeTypeName("UINT")] uint uiProperty, [NativeTypeName("PUINT")] uint* puiDataType, [NativeTypeName("LPINT")] int* piValue, FILETIME* pftValue, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSummaryInfoPersist([NativeTypeName("MSIHANDLE")] uint hSummaryInfo);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiOpenDatabaseA([NativeTypeName("LPCSTR")] sbyte* szDatabasePath, [NativeTypeName("LPCSTR")] sbyte* szPersist, [NativeTypeName("MSIHANDLE *")] uint* phDatabase);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiOpenDatabaseW([NativeTypeName("LPCWSTR")] ushort* szDatabasePath, [NativeTypeName("LPCWSTR")] ushort* szPersist, [NativeTypeName("MSIHANDLE *")] uint* phDatabase);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseImportA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szFolderPath, [NativeTypeName("LPCSTR")] sbyte* szFileName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseImportW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szFolderPath, [NativeTypeName("LPCWSTR")] ushort* szFileName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseExportA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName, [NativeTypeName("LPCSTR")] sbyte* szFolderPath, [NativeTypeName("LPCSTR")] sbyte* szFileName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseExportW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName, [NativeTypeName("LPCWSTR")] ushort* szFolderPath, [NativeTypeName("LPCWSTR")] ushort* szFileName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseMergeA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseMerge, [NativeTypeName("LPCSTR")] sbyte* szTableName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseMergeW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseMerge, [NativeTypeName("LPCWSTR")] ushort* szTableName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseGenerateTransformA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseReference, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iReserved1, int iReserved2);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseGenerateTransformW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseReference, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iReserved1, int iReserved2);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseApplyTransformA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iErrorConditions);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseApplyTransformW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iErrorConditions);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiCreateTransformSummaryInfoA([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseReference, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iErrorConditions, int iValidation);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiCreateTransformSummaryInfoW([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE")] uint hDatabaseReference, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iErrorConditions, int iValidation);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDatabaseCommit([NativeTypeName("MSIHANDLE")] uint hDatabase);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSIDBSTATE MsiGetDatabaseState([NativeTypeName("MSIHANDLE")] uint hDatabase);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("MSIHANDLE")]
        public static extern uint MsiCreateRecord([NativeTypeName("UINT")] uint cParams);

        [DllImport("msi", ExactSpelling = true)]
        public static extern BOOL MsiRecordIsNull([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordDataSize([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordSetInteger([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, int iValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordSetStringA([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPCSTR")] sbyte* szValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordSetStringW([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPCWSTR")] ushort* szValue);

        [DllImport("msi", ExactSpelling = true)]
        public static extern int MsiRecordGetInteger([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordGetStringA([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordGetStringW([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordGetFieldCount([NativeTypeName("MSIHANDLE")] uint hRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordSetStreamA([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPCSTR")] sbyte* szFilePath);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordSetStreamW([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("LPCWSTR")] ushort* szFilePath);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordReadStream([NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("UINT")] uint iField, [NativeTypeName("char *")] sbyte* szDataBuf, [NativeTypeName("LPDWORD")] uint* pcbDataBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiRecordClearData([NativeTypeName("MSIHANDLE")] uint hRecord);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("MSIHANDLE")]
        public static extern uint MsiGetActiveDatabase([NativeTypeName("MSIHANDLE")] uint hInstall);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetPropertyA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szName, [NativeTypeName("LPCSTR")] sbyte* szValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetPropertyW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szName, [NativeTypeName("LPCWSTR")] ushort* szValue);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetPropertyA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szName, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetPropertyW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szName, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("LANGID")]
        public static extern ushort MsiGetLanguage([NativeTypeName("MSIHANDLE")] uint hInstall);

        [DllImport("msi", ExactSpelling = true)]
        public static extern BOOL MsiGetMode([NativeTypeName("MSIHANDLE")] uint hInstall, MSIRUNMODE eRunMode);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetMode([NativeTypeName("MSIHANDLE")] uint hInstall, MSIRUNMODE eRunMode, BOOL fState);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiFormatRecordA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("LPSTR")] sbyte* szResultBuf, [NativeTypeName("LPDWORD")] uint* pcchResultBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiFormatRecordW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("MSIHANDLE")] uint hRecord, [NativeTypeName("LPWSTR")] ushort* szResultBuf, [NativeTypeName("LPDWORD")] uint* pcchResultBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDoActionA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiDoActionW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSequenceA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szTable, [NativeTypeName("INT")] int iSequenceMode);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSequenceW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szTable, [NativeTypeName("INT")] int iSequenceMode);

        [DllImport("msi", ExactSpelling = true)]
        public static extern int MsiProcessMessage([NativeTypeName("MSIHANDLE")] uint hInstall, INSTALLMESSAGE eMessageType, [NativeTypeName("MSIHANDLE")] uint hRecord);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSICONDITION MsiEvaluateConditionA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szCondition);

        [DllImport("msi", ExactSpelling = true)]
        public static extern MSICONDITION MsiEvaluateConditionW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szCondition);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureStateA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureStateW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetFeatureStateA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE iState);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetFeatureStateW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE iState);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetFeatureAttributesA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetFeatureAttributesW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetComponentStateA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetComponentStateW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetComponentStateA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, INSTALLSTATE iState);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetComponentStateW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, INSTALLSTATE iState);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureCostA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, MSICOSTTREE iCostTree, INSTALLSTATE iState, [NativeTypeName("LPINT")] int* piCost);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureCostW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, MSICOSTTREE iCostTree, INSTALLSTATE iState, [NativeTypeName("LPINT")] int* piCost);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiEnumComponentCostsA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("DWORD")] uint dwIndex, INSTALLSTATE iState, [NativeTypeName("LPSTR")] sbyte* szDriveBuf, [NativeTypeName("LPDWORD")] uint* pcchDriveBuf, [NativeTypeName("LPINT")] int* piCost, [NativeTypeName("LPINT")] int* piTempCost);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiEnumComponentCostsW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("DWORD")] uint dwIndex, INSTALLSTATE iState, [NativeTypeName("LPWSTR")] ushort* szDriveBuf, [NativeTypeName("LPDWORD")] uint* pcchDriveBuf, [NativeTypeName("LPINT")] int* piCost, [NativeTypeName("LPINT")] int* piTempCost);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetInstallLevel([NativeTypeName("MSIHANDLE")] uint hInstall, int iInstallLevel);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureValidStatesA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("LPDWORD")] uint* lpInstallStates);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetFeatureValidStatesW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("LPDWORD")] uint* lpInstallStates);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetSourcePathA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPSTR")] sbyte* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetSourcePathW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPWSTR")] ushort* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetTargetPathA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPSTR")] sbyte* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiGetTargetPathW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPWSTR")] ushort* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetTargetPathA([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPCSTR")] sbyte* szFolderPath);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiSetTargetPathW([NativeTypeName("MSIHANDLE")] uint hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPCWSTR")] ushort* szFolderPath);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiVerifyDiskSpace([NativeTypeName("MSIHANDLE")] uint hInstall);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiEnableUIPreview([NativeTypeName("MSIHANDLE")] uint hDatabase, [NativeTypeName("MSIHANDLE *")] uint* phPreview);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiPreviewDialogA([NativeTypeName("MSIHANDLE")] uint hPreview, [NativeTypeName("LPCSTR")] sbyte* szDialogName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiPreviewDialogW([NativeTypeName("MSIHANDLE")] uint hPreview, [NativeTypeName("LPCWSTR")] ushort* szDialogName);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiPreviewBillboardA([NativeTypeName("MSIHANDLE")] uint hPreview, [NativeTypeName("LPCSTR")] sbyte* szControlName, [NativeTypeName("LPCSTR")] sbyte* szBillboard);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint MsiPreviewBillboardW([NativeTypeName("MSIHANDLE")] uint hPreview, [NativeTypeName("LPCWSTR")] ushort* szControlName, [NativeTypeName("LPCWSTR")] ushort* szBillboard);

        [DllImport("msi", ExactSpelling = true)]
        [return: NativeTypeName("MSIHANDLE")]
        public static extern uint MsiGetLastErrorRecord();

        [NativeTypeName("#define MSI_NULL_INTEGER 0x80000000")]
        public const uint MSI_NULL_INTEGER = 0x80000000;

        [NativeTypeName("#define MSIDBOPEN_READONLY (LPCTSTR)0")]
        public static ushort* MSIDBOPEN_READONLY => (ushort*)(0);

        [NativeTypeName("#define MSIDBOPEN_TRANSACT (LPCTSTR)1")]
        public static ushort* MSIDBOPEN_TRANSACT => (ushort*)(1);

        [NativeTypeName("#define MSIDBOPEN_DIRECT (LPCTSTR)2")]
        public static ushort* MSIDBOPEN_DIRECT => (ushort*)(2);

        [NativeTypeName("#define MSIDBOPEN_CREATE (LPCTSTR)3")]
        public static ushort* MSIDBOPEN_CREATE => (ushort*)(3);

        [NativeTypeName("#define MSIDBOPEN_CREATEDIRECT (LPCTSTR)4")]
        public static ushort* MSIDBOPEN_CREATEDIRECT => (ushort*)(4);

        [NativeTypeName("#define MSIDBOPEN_PATCHFILE 32/sizeof(*MSIDBOPEN_READONLY)")]
        public const uint MSIDBOPEN_PATCHFILE = 32 / 2;

        [NativeTypeName("#define INSTALLMESSAGE_TYPEMASK 0xFF000000L")]
        public const uint INSTALLMESSAGE_TYPEMASK = 0xFF000000;

        [NativeTypeName("#define MsiDatabaseOpenView MsiDatabaseOpenViewW")]
        public static delegate*<uint, ushort*, uint*, uint> MsiDatabaseOpenView => &MsiDatabaseOpenViewW;

        [NativeTypeName("#define MsiViewGetError MsiViewGetErrorW")]
        public static delegate*<uint, ushort*, uint*, MSIDBERROR> MsiViewGetError => &MsiViewGetErrorW;

        [NativeTypeName("#define MsiDatabaseGetPrimaryKeys MsiDatabaseGetPrimaryKeysW")]
        public static delegate*<uint, ushort*, uint*, uint> MsiDatabaseGetPrimaryKeys => &MsiDatabaseGetPrimaryKeysW;

        [NativeTypeName("#define MsiDatabaseIsTablePersistent MsiDatabaseIsTablePersistentW")]
        public static delegate*<uint, ushort*, MSICONDITION> MsiDatabaseIsTablePersistent => &MsiDatabaseIsTablePersistentW;

        [NativeTypeName("#define MsiGetSummaryInformation MsiGetSummaryInformationW")]
        public static delegate*<uint, ushort*, uint, uint*, uint> MsiGetSummaryInformation => &MsiGetSummaryInformationW;

        [NativeTypeName("#define MsiSummaryInfoSetProperty MsiSummaryInfoSetPropertyW")]
        public static delegate*<uint, uint, uint, int, FILETIME*, ushort*, uint> MsiSummaryInfoSetProperty => &MsiSummaryInfoSetPropertyW;

        [NativeTypeName("#define MsiSummaryInfoGetProperty MsiSummaryInfoGetPropertyW")]
        public static delegate*<uint, uint, uint*, int*, FILETIME*, ushort*, uint*, uint> MsiSummaryInfoGetProperty => &MsiSummaryInfoGetPropertyW;

        [NativeTypeName("#define MsiOpenDatabase MsiOpenDatabaseW")]
        public static delegate*<ushort*, ushort*, uint*, uint> MsiOpenDatabase => &MsiOpenDatabaseW;

        [NativeTypeName("#define MsiDatabaseImport MsiDatabaseImportW")]
        public static delegate*<uint, ushort*, ushort*, uint> MsiDatabaseImport => &MsiDatabaseImportW;

        [NativeTypeName("#define MsiDatabaseExport MsiDatabaseExportW")]
        public static delegate*<uint, ushort*, ushort*, ushort*, uint> MsiDatabaseExport => &MsiDatabaseExportW;

        [NativeTypeName("#define MsiDatabaseMerge MsiDatabaseMergeW")]
        public static delegate*<uint, uint, ushort*, uint> MsiDatabaseMerge => &MsiDatabaseMergeW;

        [NativeTypeName("#define MsiDatabaseGenerateTransform MsiDatabaseGenerateTransformW")]
        public static delegate*<uint, uint, ushort*, int, int, uint> MsiDatabaseGenerateTransform => &MsiDatabaseGenerateTransformW;

        [NativeTypeName("#define MsiDatabaseApplyTransform MsiDatabaseApplyTransformW")]
        public static delegate*<uint, ushort*, int, uint> MsiDatabaseApplyTransform => &MsiDatabaseApplyTransformW;

        [NativeTypeName("#define MsiCreateTransformSummaryInfo MsiCreateTransformSummaryInfoW")]
        public static delegate*<uint, uint, ushort*, int, int, uint> MsiCreateTransformSummaryInfo => &MsiCreateTransformSummaryInfoW;

        [NativeTypeName("#define MsiRecordSetString MsiRecordSetStringW")]
        public static delegate*<uint, uint, ushort*, uint> MsiRecordSetString => &MsiRecordSetStringW;

        [NativeTypeName("#define MsiRecordGetString MsiRecordGetStringW")]
        public static delegate*<uint, uint, ushort*, uint*, uint> MsiRecordGetString => &MsiRecordGetStringW;

        [NativeTypeName("#define MsiRecordSetStream MsiRecordSetStreamW")]
        public static delegate*<uint, uint, ushort*, uint> MsiRecordSetStream => &MsiRecordSetStreamW;

        [NativeTypeName("#define MsiSetProperty MsiSetPropertyW")]
        public static delegate*<uint, ushort*, ushort*, uint> MsiSetProperty => &MsiSetPropertyW;

        [NativeTypeName("#define MsiGetProperty MsiGetPropertyW")]
        public static delegate*<uint, ushort*, ushort*, uint*, uint> MsiGetProperty => &MsiGetPropertyW;

        [NativeTypeName("#define MsiFormatRecord MsiFormatRecordW")]
        public static delegate*<uint, uint, ushort*, uint*, uint> MsiFormatRecord => &MsiFormatRecordW;

        [NativeTypeName("#define MsiDoAction MsiDoActionW")]
        public static delegate*<uint, ushort*, uint> MsiDoAction => &MsiDoActionW;

        [NativeTypeName("#define MsiSequence MsiSequenceW")]
        public static delegate*<uint, ushort*, int, uint> MsiSequence => &MsiSequenceW;

        [NativeTypeName("#define MsiEvaluateCondition MsiEvaluateConditionW")]
        public static delegate*<uint, ushort*, MSICONDITION> MsiEvaluateCondition => &MsiEvaluateConditionW;

        [NativeTypeName("#define MsiGetFeatureState MsiGetFeatureStateW")]
        public static delegate*<uint, ushort*, INSTALLSTATE*, INSTALLSTATE*, uint> MsiGetFeatureState => &MsiGetFeatureStateW;

        [NativeTypeName("#define MsiSetFeatureState MsiSetFeatureStateW")]
        public static delegate*<uint, ushort*, INSTALLSTATE, uint> MsiSetFeatureState => &MsiSetFeatureStateW;

        [NativeTypeName("#define MsiSetFeatureAttributes MsiSetFeatureAttributesW")]
        public static delegate*<uint, ushort*, uint, uint> MsiSetFeatureAttributes => &MsiSetFeatureAttributesW;

        [NativeTypeName("#define MsiGetComponentState MsiGetComponentStateW")]
        public static delegate*<uint, ushort*, INSTALLSTATE*, INSTALLSTATE*, uint> MsiGetComponentState => &MsiGetComponentStateW;

        [NativeTypeName("#define MsiSetComponentState MsiSetComponentStateW")]
        public static delegate*<uint, ushort*, INSTALLSTATE, uint> MsiSetComponentState => &MsiSetComponentStateW;

        [NativeTypeName("#define MsiGetFeatureCost MsiGetFeatureCostW")]
        public static delegate*<uint, ushort*, MSICOSTTREE, INSTALLSTATE, int*, uint> MsiGetFeatureCost => &MsiGetFeatureCostW;

        [NativeTypeName("#define MsiEnumComponentCosts MsiEnumComponentCostsW")]
        public static delegate*<uint, ushort*, uint, INSTALLSTATE, ushort*, uint*, int*, int*, uint> MsiEnumComponentCosts => &MsiEnumComponentCostsW;

        [NativeTypeName("#define MsiGetFeatureValidStates MsiGetFeatureValidStatesW")]
        public static delegate*<uint, ushort*, uint*, uint> MsiGetFeatureValidStates => &MsiGetFeatureValidStatesW;

        [NativeTypeName("#define MsiGetSourcePath MsiGetSourcePathW")]
        public static delegate*<uint, ushort*, ushort*, uint*, uint> MsiGetSourcePath => &MsiGetSourcePathW;

        [NativeTypeName("#define MsiGetTargetPath MsiGetTargetPathW")]
        public static delegate*<uint, ushort*, ushort*, uint*, uint> MsiGetTargetPath => &MsiGetTargetPathW;

        [NativeTypeName("#define MsiSetTargetPath MsiSetTargetPathW")]
        public static delegate*<uint, ushort*, ushort*, uint> MsiSetTargetPath => &MsiSetTargetPathW;

        [NativeTypeName("#define MsiPreviewDialog MsiPreviewDialogW")]
        public static delegate*<uint, ushort*, uint> MsiPreviewDialog => &MsiPreviewDialogW;

        [NativeTypeName("#define MsiPreviewBillboard MsiPreviewBillboardW")]
        public static delegate*<uint, ushort*, ushort*, uint> MsiPreviewBillboard => &MsiPreviewBillboardW;
    }
}
