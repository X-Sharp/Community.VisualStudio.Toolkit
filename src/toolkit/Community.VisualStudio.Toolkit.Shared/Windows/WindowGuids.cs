﻿namespace Community.VisualStudio.Toolkit
{
    /// <summary>
    /// Provides GUIDs that are used to identify Visual Studio tool windows.
    /// </summary>
    public class WindowGuids
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string MainWindow = "{9DDABE98-1D02-11D3-89A1-00C04F688DDE}";

        public const string DocumentWell = "DocumentWell";

        public const string CallStack = "{0504FF91-9D61-11D0-A794-00A0C9110051}";

        public const string Locals = "{4A18F9D0-B838-11D0-93EB-00A0C90F2734}";

        public const string Watch = "{90243340-BD7A-11D0-93EF-00A0C90F2734}";

        public const string Properties = "{EEFA5220-E298-11D0-8F78-00A0C9110057}";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>The Git Changes window introduced in Visual Studio 2019.</summary>
        public const string GitChanges = "{1C64B9C2-E352-428E-A56D-0ACE190B99A6}";

        /// <summary>The Git Repository window introduced in Visual Studio 2019.</summary>
        public const string GitRepository = "{1C4FEEAA-4718-4AA9-859D-94CE25D182BA}";

        /// <summary>The Error List window.</summary>
        public const string ErrorList = "{D78612C7-9962-4B83-95D9-268046DAD23A}";

        /// <summary>
        /// Provides a list of components that can be added to a project, typically through the Windows Forms designer.
        /// </summary>
        public const string Toolbox = "{B1E99781-AB81-11D0-B683-00AA00A3EE26}";

        /// <summary>
        /// Provides a list of properties associated with the currently selected file or project in the Solution Explorer.
        /// </summary>
        public const string PropertyBrowser = "{EEFA5220-E298-11D0-8F78-00A0C9110057}";

        /// <summary>
        /// Provides a list of projects and their files in a solution.
        /// </summary>
        public const string SolutionExplorer = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}";

        /// <summary>Displays any output generated by a build process or a program being debugged.</summary>
        public const string OutputWindow = "{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}";

        /// <summary>Provides an outline of an HTML file.</summary>
        public const string DocOutline = "{25F7E850-FFA1-11D0-B63F-00A0C922E851}";

        /// <summary>Provides a list of user-specified tasks to be accomplished for a project.</summary>
        public const string TaskList = "{4A9B7E51-AA16-11D0-A8C5-00A0C921A4D2}";

        /// <summary>Provides a list of servers used for connecting to databases.</summary>
        public const string ServerExplorer = "{74946827-37A0-11D2-A273-00C04F8EF4FF}";

        /// <summary>Provides a list of macros available for use in the Visual Studio shell.</summary>
        public const string MacroExplorer = "{07CD18B4-3BA1-11D2-890A-0060083196C6}";

        /// <summary>Provides links to help topics based on the current context.</summary>
        public const string ContextWindow = "{66DBA47C-61DF-11D2-AA79-00C04F990343}";

        /// <summary>Provides a list of all classes in a solution.</summary>
        public const string ClassView = "{C9C0AE26-AA77-11D2-B3F0-0000F87570EE}";

        /// <summary>Provides a list of resources available in a project.</summary>
        public const string ResourceView = "{2D7728C2-DE0A-45B5-99AA-89B609DFDE73}";

        /// <summary>Provides the ability to search for a symbol.</summary>
        public const string ObjectSearchWindow = "{53024D34-0EF5-11D3-87E0-00C04F7971A5}";

        /// <summary>Provides a way to execute commands directly in the Visual Studio shell.</summary>
        public const string CommandWindow = "{28836128-FC2C-11D2-A433-00C04F72D18A}";

        /// <summary>Provides the results of searching for a symbol.</summary>
        public const string ObjectSearchResultsWindow = "{68487888-204A-11D3-87EB-00C04F7971A5}";

        /// <summary>Provides a list of components installed on the system.</summary>
        public const string ObjectBrowser = "{269A02DC-6AF8-11D3-BDC4-00C04F688E50}";

        /// <summary>For internal use only.</summary>
        public const string BrowserDoc = "{6B8E94B4-0949-4D9C-A81F-C1B9B744185C}";

        /// <summary>Provides the ability to search and replace on the currently opened file.</summary>
        public const string FindReplace =
#if VS14 || VS15
            "{CF2DDC32-8CAD-11D2-9302-005345000000}"
#else
            "{6324226F-61B6-4F28-92EE-18D4B5FE1E48}"
#endif
            ;
        
        /// <summary>Provides the ability to search files for a string.</summary>
        public const string FindAdvanced = "{E830EC50-C2B5-11D2-9375-0080C747D9A0}";

        /// <summary>Provides a list of the search results.</summary>
        public const string FindResults1 = "{0F887920-C2B6-11D2-9375-0080C747D9A0}";

        /// <summary>Provides a second list of search results.</summary>
        public const string FindResults2 = "{0F887921-C2B6-11D2-9375-0080C747D9A0}";

        /// <summary>Provides a command prompt for PowerShell.</summary>
        public const string DeveloperPowerShell = "{D212F56B-C48A-434C-A121-1C5D80B59B9F}";
    }
}