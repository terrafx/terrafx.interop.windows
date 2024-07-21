// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SearchSuggestionKind.xml' path='doc/member[@name="SearchSuggestionKind"]/*' />
public enum SearchSuggestionKind
{
    /// <include file='SearchSuggestionKind.xml' path='doc/member[@name="SearchSuggestionKind.SearchSuggestionKind_Query"]/*' />
    SearchSuggestionKind_Query = 0,

    /// <include file='SearchSuggestionKind.xml' path='doc/member[@name="SearchSuggestionKind.SearchSuggestionKind_Result"]/*' />
    SearchSuggestionKind_Result = 1,

    /// <include file='SearchSuggestionKind.xml' path='doc/member[@name="SearchSuggestionKind.SearchSuggestionKind_Separator"]/*' />
    SearchSuggestionKind_Separator = 2,
}
